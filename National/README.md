# _Park Api_

#### By: _**Brandon Fenk**_

#### _Files, Code, and setup with comments for using Identity and Roles to add to projects._

## Technologies Used


* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 6.0.0](https://docs.microsoft.com/en-us/ef/core/)
* [Swagger](https://docs.microsoft.com/en-us/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-3.1&tabs=visual-studio)



### Description
.This is a basic Park Api. You can Search for State and National Parks. So you can also see the ratings and summary of the park you can to look up.
## Setup/Installation Requirements

* _Clone the repository to your desktop from: https://github.com/BrandonF55/ParkApi.Solutions.git_
* _Create appsettings.json file in ASPNETIdentityRoles folder_

```
{
    "Logging": {
      "LogLevel": {
        "Default": "Information",
        "Microsoft.AspNetCore": "Warning"
      }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=park_api;uid=root;pwd=epicodus;"
    }
  }

```
* _run dotnet commands below in _National_
```
dotnet restore
```
```
dotnet ef database update
```
```
dotnet watch run
```
 #### Launch the API
  1) Navigate to ParkApi.Solution/National directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/ParkApi.Solution/National`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.


### Endpoints
Base URL: `https://localhost:7165`

#### HTTP Request Structure
```
GET /api/{component}
PUT /api/{component}
DELETE /api/{component}/{id}
GET /api/{component}/{id}
POST /api/{component}/{id}
```

#### Example Query

```
https://localhost:7165/api/Park/1

```

#### Sample JSON Response
``` 
{
  "parkId": 1,
  "name": "portland",
  "states": null
}

```

#### Example Query

```
https://localhost:7165/api/State


```
#### Sample JSON Response
``` 
{
  "stateId": 2,
  "summary": "portland sucks",
  "rating": 5,
  "parkId": 1
}

```

## Known Bugs

* _No known issues in APi_ I couldn't fully implement the Token Bearer Authorzation. You can access it by switching to the Auth branch on my GitHub repositorie_

## License

_Copyright (c) 2022 Brandon Fenk_

_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._
