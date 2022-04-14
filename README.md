---
languages:
- csharp
page_type: sample
description: "The project should be started by selecting multiple startup projects from the Solution properties and then selecting the Case Study.Api and CaseStudy.Web options."
products:
- aspnet-core-api
- aspnet-core
- refit
- jwt
- swagger
---

# ASP.NET Core API and ASP.NET Core MVC project
The project should be started by selecting multiple startup projects from the Solution properties and then selecting the Case Study.Api and CaseStudy.Web options.

- Authenticate method should be used for **Authroize**.
- User name and password information are in the project.
- After the Authenticate method, it must be Authroized with the token.
- **GenerateCodes** method should be used to generate code.
- **CheckCode** method should be used for code validity control.
- The code is created according to the determined rule.
- Rule : The 3rd digit from the beginning is odd number, the second from the last digit is even number, the first digit and the last digit must be letters and lowercase. (All must be from the given character set.)
- Swagger Dashboard: https://localhost:44319/swagger 
- Authanticate information is located below
   - UserName="Oguzhan" - Password="1234" OR UserName="CaseStudy" - Password="12345"

* Method names are shown in bold.

## License

See [LICENSE](https://github.com/oguzhanyikilmaz/CaseStudy/blob/master/LICENSE.md).

## Contributing

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [oguzhanyklmz27@gmail.com](mailto:oguzhanyklmz27@gmail.com) with any additional questions or comments.
