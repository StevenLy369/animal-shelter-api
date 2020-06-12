
# Animal Shelter
#### _Epicodus Project June 12, 2020_

#### By _**Steven Ly**_



## Description

_A project that has CRUD functionaility as well as Swagger implemented_

## Setup/Installation Requirements

1. Clone this repository from GitHub.
2. Install MySQL on your computer.
3. Open the downloaded directory in a text editor of your choice.
4. In your terminal, navigate to the project directory and run the commands dotnet restore and dotnet build to download dependencies and build the configuration.
5. Currently, the mySQL database is set up with an appsettings.json file that was not uploaded to Github.  Once you have saved the SQL database on your computer, create an appsettings.json file in the project root directory, and update it with your MySQL installation information in this format:
  ```
  {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=[YOUR PORT NUMBER HERE];database=[DATABASE NAME AS YOU SAVED IT];uid=YOUR USER ID HERE;pwd=[YOUR PASSWORD HERE];"
  }
}
```
6. To run MySQL migrations and create a database in your MySQL installation, enter the following command in your terminal: ```dotnet ef migrations``` add ```Initial && dotnet ef database update```.
7. This API uses Swagger. To launch the Swagger/OpenAPI utility in your browser, from the project directory in your terminal, enter ```dotnet run``` and open a browser page at localhost:5000.  You can now see all API routes grouped by controller.  Clicking on a route will expand it and show details of that route, and give you the option to "Try It Out."


## Known Bugs

There are no known bugs at the time of this update.

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue] here on GitHub._

### User Story

* As a user, I want to be able GET animals that are stored in the shelter.
* As a user, I want to be able to POST a new animal for adoption.
* As a user, I want to be able to PUT and DELETE animals that I have created.
* As a user, I want to be able to look up remedies by name, breed.

## Technologies Used

* C#
* .NET Core
* ASP.NET Core MVC
* MySQL
* Identity
* MSBuild
* Git and GitHub
* Swagger/OpenAPI


### License
This software is licensed under the MIT license.

Copyright (c) 2020 **_Steven Ly_**