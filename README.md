# ScholarOneEF 

ASP.NET C# Library to Consume ScholarOne API (Entity Framework) 

 

## About 

This library provides a factory to retrieve content from [ScholarOne](https://clarivate.com/webofsciencegroup/support/scholarone-manuscripts/for-developers/) by consuming their various [API services](https://clarivate.com/webofsciencegroup/wp-content/uploads/sites/2/2021/06/API_Reference_NOV2020.pdf). Raw API content is returned as a string to be processed as needed by the project. 

 

This library is written in ASP.NET C# using Entity Framework. The author is not affiliated with Clarivate or ScholarOne, and this library is in no way officially supported by Clarivate or representative of their work. The intended use is to assist developers in consuming ScholarOne API in ASP.NET C# projects. To get a ScholarOne user name and API key, you must contact Clarivate support. 

 

This project is under active development. 

 

## Digest Authentication 

ScholarOne API services use [digest authentication](https://httpwg.org/specs/rfc7616.html). However, there is an [obscure bug](https://stackoverflow.com/questions/3109507/httpwebrequests-sends-parameterless-uri-in-authorization-header) when attempting to consume services using digest authentication with parameters in the Uri. Digest standards require that the Uri in the authorization header match the Uri being requested, but ASP.NET leaves out the query parameters in the authorization header. This requires a work around in ASP.NET in order to consume ScholarOne API, and was the main impetus of this library. 

 

This library implements custom processing of the authorization header, with built in support for using [HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-6.0&viewFallbackFrom=net-4.7.2) or [WebClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient?view=net-6.0&viewFallbackFrom=net-4.7.2) classes to make http requests. Projects are free to make custom implementations of the BaseFactory class with their own implementations of the http requests. 
