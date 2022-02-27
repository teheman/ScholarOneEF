# ScholarOneEF 

ASP.NET C# (Entity Framework) Library to Consume ScholarOne API 

 

## About 

The purpose of this library is to provide basic functionality to retrieve data from [ScholarOne](https://clarivate.com/webofsciencegroup/support/scholarone-manuscripts/for-developers/) by consuming their [API services](https://clarivate.com/webofsciencegroup/wp-content/uploads/sites/2/2021/06/API_Reference_NOV2020.pdf). This library implements a factory with a separate method to consume each ScholarOne service. The factory is configurable for project requirements, and enforces that required parameters are provided. API responses returned from ScholarOne are left as raw strings for developers to process as needed. 

 

This library was developed in Microsoft Visual Studio and contains one class library written in C# using Entity Framework 4.7.2. There are no dependencies on any Nuget Packages. There is one assembly in this library. 

 

This repository is not affiliated with or supported by Clarivate or ScholarOne. Using this library requires a user name and API key which must be obtained through ScholarOne support. No guarantees are provided that this repository will be kept up to date with any future changes in the ScholarOne API. 

 

This project is under active development. 

 

## Digest Authentication 

ScholarOne API services use [digest authentication](https://httpwg.org/specs/rfc7616.html). ASP.NET is capable of consuming services using digest authentication by [providing credentials](https://docs.microsoft.com/en-us/dotnet/api/system.net.networkcredential?view=net-6.0). However, there is an [obscure bug](https://stackoverflow.com/questions/3109507/httpwebrequests-sends-parameterless-uri-in-authorization-header) when attempting to consume services using digest authentication with query parameters in the Uri. Digest standards require that the Uri in the authorization header match the Uri being requested, but ASP.NET leaves out the query parameters in the authorization header. This requires a work around in ASP.NET in order to consume ScholarOne API, and was the main impetus of this library. 

 

This library implements custom processing of the authorization header, with built in support for using [HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-6.0&viewFallbackFrom=net-4.7.2) or [WebClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient?view=net-6.0&viewFallbackFrom=net-4.7.2) classes to make http requests. Projects are free to make custom implementations of the BaseFactory class with their own implementations of the http requests. 
