# ScholarOneEF  
ASP.NET C# (Entity Framework) Library to Consume ScholarOne API  

## About  
The purpose of this library is to provide basic functionality to retrieve data from [ScholarOne](https://clarivate.com/webofsciencegroup/support/scholarone-manuscripts/for-developers/) by consuming their [API services](https://clarivate.com/webofsciencegroup/wp-content/uploads/sites/2/2021/06/API_Reference_NOV2020.pdf). This library implements a factory with a separate method to consume each ScholarOne service. The factory is configurable for project requirements, and enforces that required parameters are provided. API responses returned from ScholarOne are left as raw strings for developers to process as needed.  

This library was developed in Microsoft Visual Studio and contains one class library written in C# using Entity Framework 4.7.2. There are no dependencies on any other resources. There is one assembly in this library.  

This repository is not affiliated with or supported by Clarivate or ScholarOne. Using this library requires a user name and API key which must be obtained through ScholarOne support. No guarantees are provided that this repository will be kept up to date with any future changes in the ScholarOne API. 

This project is under active development. 

## Digest Authentication  
ScholarOne API services use [digest authentication](https://httpwg.org/specs/rfc7616.html). ASP.NET is capable of consuming services using digest authentication by [providing credentials](https://docs.microsoft.com/en-us/dotnet/api/system.net.networkcredential?view=net-6.0). However, there is an [obscure bug](https://stackoverflow.com/questions/3109507/httpwebrequests-sends-parameterless-uri-in-authorization-header) when attempting to consume services using digest authentication with query parameters in the Uri. Digest standards require that the Uri in the authorization header match the Uri being requested, but ASP.NET leaves out the query parameters in the authorization header. This requires a work around in ASP.NET in order to consume ScholarOne API, and was the main impetus of this library.  

This library implements custom processing of the authorization header, with built in support for using [HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-6.0&viewFallbackFrom=net-4.7.2) or [WebClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient?view=net-6.0&viewFallbackFrom=net-4.7.2) classes to make http requests. Projects are free to make custom implementations of the BaseFactory class with their own implementations of the http requests.  

## Using the Library  

### Initialize the Factory  

The included factory has several constructors. The minimum requirements are a user name, api key, and the site name. The settings can also be updated after factory initialization. Initializing the factory and the default value of the optional properties are shown below.

```C#
// Initialize factory with minimum requirements  
var factory = new ScholarOneApi.Factory("user name", "api key", "site name");  

// configure the factory  

// factory defaults  
factory.ResponseType = ScholarOneApi.ResponseTypeEnum.xml; 
factory.LocaleId = ScholarOneApi.LocaleIdEnum.English;  
factory.Environment = ScholarOneApi.EnvironmentEnum.Integration;  
factory.PropogateErrors = true;  

// other settings  
factory.ExternalId = "my external id";  
``` 

The configurable factory settings are either a simple data type or an enum. 

| Property | Description | Values | Default | 
| ---      | ---       | ---      | ---        
| Environment | Determines if the factory will make requests from the integration or production environments provided by ScholarOne. | EnvironmentEnum | Integration | 
| ExternalId | Custom id that can be set for audit purposes *(optional)* | User supplied string | null | 
| LocaleId | Identifier for the ScholarOne language (must match the caller's profile) | LocaleIdEnum | English | 
| PropogateErrors | This property determines if errors consuming the API will be thrown to the application layer. By default, errors will not be caught (PropogateErrors is true). Set PropogateErrors to false to enable the factory to catch errors. Caught errors will be set to the Error property of the returned service result object, and the Success property will be set to false. | Boolean | true | 
| ResponseType | The format for data returned by ScholarOne | ResponseTypeEnum | XML | 

### Retrieve Data
Each ScholarOne API resource has its own method call in the factory. Use the factory method that corresponds the ScholarOne API that needs to be consumed. These methods are asynchronous.
```C#
// consume API
var submissionIds = new List<string> { "submission id 1", "submission id 2" };
var result = await factory.GetAuthorFullBySubmissionId(submissionIds);
```
List of factory methods
  - GetAuthorFullBySubmissionId
  - GetAuthorFullByDocumentId
  - GetAuthorBasicBySubmissionId
  - GetAuthorBasicByDocumentId
  - GetReviewerInfoFullBySubmissionId
  - GetReviewerInfoFullByDocumentId
  - GetSubmissionInfoBasicBySubmissionId
  - GetSubmissionInfoBasicByDocumentId
  - GetSubmissionFullBySubmissionId
  - GetSubmissionFullByDocumentId
  - GetStaffInfoFullBySubmissionId
  - GetStaffInfoFullByDocumentId
  - GetSubmissionVersionsBySubmissionId
  - GetSubmissionVersionsByDocumentId
  - GetPersonInfoBasicId
  - GetPersonInfoBasicEmail
  - GetPersonInfoFullId
  - GetPersonInfoFullEmail
  - GetDecisionCorrespondenceFullSubmissionId
  - GetDecisionCorrespondenceFullDocumentId
  - GetExternalDocumentIdsFull

### Process the result
The factory methods return an object referred to as a "service result" in this library. Each method returns its own service result object, but they all have common properties found in the table below.
| Property | Description | Data Type | 
| ---      | ---       | ---       
| Duration | The amount of time it took to execute the factory method | TimeSpan |
| Environment | The ScholarOne environment where the API request was made | EnvironmentEnum |
| Error | The ASP.NET exception encountered while trying to complete the request, if any; This will only be populated if the factory PropogateErrors is set to false and an exception is encountered | Exception |
| Success | Indicates if the factory method executed without exceptions; This can only be false if the factory PropogateErrors is set to false | Boolean |
| Uri | The Uri that the factory used to make the service request | Uri |
| Response | The raw data returned by ScholarOne | string |
| ReturnType | The format of data that was requested from ScholarOne (XML or json) | ResponseTypeEnum |

Processing the data depends on the format of the data requested. For example, an XML response can be manipulated with the [XmlDocument](https://docs.microsoft.com/en-us/dotnet/api/system.xml.xmldocument?view=net-6.0) class.
```C#
// Load the Scholar One XML
var xmlDoc = new System.Xml.XmlDocument();
xmlDoc.LoadXml(result.Response);

// Do something with the XML
```

The Response property can be an empty string, and must be handled by the application code.

## Customizing the Factory
The factory provided is optional. Developers are free to implement their own factory class by overriding the BaseFactory class. There are two methods that must be implemented by the child class, as described in the table below.

| Method | Description | 
| ---      | ---     
| GetInitialAuthorizationHeader | This method performs the initial http request to ScholarOne. The request will receive an Unauthorized (401) response which includes an Authorization header. This method must return the Authorization header so that the BaseFactory can extract the digest authentication values from it. |
| GetAuthorizedResponse | This method performs the second request to ScholarOne with the corrected Authorization header. ScholarOne will return the requested data in the response body, which the method must return to the BaseFactory. |

A basic implementation of the factory class can be started from the code below.
```C#
public class CustomFactory : ScholarOneApi.BaseFactory
{
    public CustomFactory(string user, string password, string siteName) : base(user, password, siteName)
    {
        // Set factory settings
    }

    protected override Task<string> GetInitialAuthorizationHeader(Uri uri)
    {
        // Implement custom GET request to the URI specified
        // return the authorization header of the ScholarOne response

        throw new NotImplementedException();
    }

    protected override Task<string> GetAuthorizedResponse(Uri uri, string authorizationHeader)
    {
        // Implement custom GET request to the URI specified
        // The authorization header of the request must be set to the authorizationHeader parameter
        // return the response body from ScholarOne
            
        throw new NotImplementedException();
    }
}
```
