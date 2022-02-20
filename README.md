# TaxCalculation
Tax Calculation service using ASP.NET Core Web APIs and Clean Architecture.

The solution currently consists of four projects:
* Web API
* Core
* Infrastructure
* Tests

The Web API's Swagger page allows you to call Tax Service implementations.

* Only TaxJar has been implemented thus far: https://developers.taxjar.com/api/reference/.
* TaxJar has an open source C# SDK (found here: https://github.com/taxjar/taxjar.net), but we're calling their Web API in this instance.

The Core project holds all business logic and base data types (specifically interfaces).

The Infrastructure project holds our implementations and external calls to things like databases, external web APIs, etc.

The Tests project holds our tests, both for mocking external services and internal business logic.

Web API requires an appsettings.json with the following format. Be sure to populate the API key before use.

{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "TaxJarApi": {
    "TaxesEndpoint": "https://api.taxjar.com/v2/taxes",
    "RatesEndpoint": "https://api.taxjar.com/v2/rates",
    "ApiKey": ""
  }
}
