# National Park API

#### By Timothy Empey

#### Locally hosted national park API 

## Technologies Used

* C#
* ASP.NET
* Razor
* MySQL
* EF Core

## Description 

Web API which allows for creating, deleting, editing, and viewing a database of national parks, some basic information on them, and a list of activities made with a one to many relationship. Viewable through postman as well as swagger through https://localhost:5000/swagger.

## Setup & Installation

* Clone github repository from "https://github.com/TimEmpey/ParkAPI.git"
* In the root directory, confirm there is a .gitignore file and add the following

```js
*/obj
*/bin
*.vscode
*/appsettings.json
```
* Create an appsetting.json file at the root directory
* Inside of appsetting.json paste the following:

```js
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[NAME OF DATABASE];uid=root;pwd=[YOUR PASSWORD];"
  }
}
```

* Run ```git add .gitignore```
* Commit this before any other file
* Run ```dotnet restore``` and ```dotnet build``` inside the terminal
* Assuming MySQL is downloaded run ```dotnet ef migrations add Initial```, if not, download MySQL and the proceed
* Run the following command: ```dotnet ef database update```
* Run the following command: ```dotnet watch run```
* click on  <http://localhost:5000>


## Swagger

Enter https://localhost:5000/swagger into your browser

You will see the CRUD options for API. These work with the API in live time to create, edit, and view elements of the database

<details>
<summary>CRUD OPTIONS</summary>

* GET /api/Parks: Allows user to look a park by it's name, state, or year it was founded.

* POST /api/Parks: Allows user to add a new park to the database

* GET /api/Parks: Allows user to look up a park by it's parkID

* PUT /api/Parks: Allows user to edit an existing park in the database after it's ID is provided

* DELETE /api/Parks: Allows user to delete an existing park in the database after it's ID is provided
</details>

<br> 

### Swagger Interface

# GET Method

<br> 

Select the GET method for parks, the route should be '/api/parks'

<br> 

To initialize the API you need to press 'Try it out'

<br> 

There should now be a view of all the current information the API holds

<br> 

# POST Method

<br> 

Select the POST method for parks, the route should be '/api/parks'

<br> 

To initialize the API you need to press 'Try it out' followed by 'Execute'

<br> 

There should now be a view of placeholder data for you to fill out

<br>

Replace this information with a parks info and hit 'Execute', you've now added data to the API

<br> 

## Known Bugs

* None


## License

_[MIT](https://en.wikipedia.org/wiki/MIT_License)_

Copyright (c) _2022_ _Timohy Empey_