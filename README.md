# _Animal Shelter Api_

#### _API w/ full CRUD_
##### __Created:__ 8/21/2020
##### __Last Updated:__ 8/21/2020 
##### By _**Chris Yoon**_  
---
---

## Description

_This is an API that lists the types of animals at a shelter._

---
---

## Behaviors

| Spec| Example Request | Example Output
| ----------- | ----------- | ----------- |
| The API GET retrieves entire list| "http://localhost:5000/api/animals" |  { "animalId": 15, "name": "Bartholsssomew","species": "Dinosaur"} |
| The API PUT edits listings| "http://localhost:5000/api/animals/{id}" | N/A |
| The API POST adds listings| "http://localhost:5000/api/animals" | N/A |
| The API DELETE delete listings | "http://localhost:5000/api/animals/{id}" | N/A |
| The API takes queries of Name & Species | "http://localhost:5000/api/animals?name=Rex" | { "animalId": 13, "name": "Rex","species": "Dog"} |
| The API is searchable by Page Number  | "http://localhost:5000/api/animals/pages?pageNumber=2&pageSize=10" | N/A |


![Route Configuration](AnimalShelterApi/wwwroot/img/swaggerimage.PNG)

---
---


## Setup/Installation Requirements

#### Open via Bash/GitBash:

1. Clone this repository onto your computer:
    "git clone https://github.com/chyoon2/AnimalShelterApi.Solution"
2. Navigate into the "Sweet.Solution" directory in Visual Studio Code or preferred IDE:
3. Open the project
    "code ."

#### Configue Appsettings.json Database:
1. Create an 'appsettings.json' file in your root folder.
2. Add the following code
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=FIRSTNAME_LASTNAME;uid=root;pwd=YOURPASSWORD"
  }
}
```
3. In the YOURPASSWORD, add your password, if you're with epicodus enter 'epicodus'.
4. This program's database name is set to lowercase 'animal_shelter'.

##### Configure Migration:
1. In your terminal run 'dotnet ef migrations add ENTERAPPROPRIATENAME'
2. Then run 'dotnet ef database update'
3. Refresh your Sql workbench to check for the 'chris_yoon' schema. You may have named it differently.

##### Host Local Server:
1. Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
2. Enter the command "dotnet build" in the terminal and press "Enter".
3. Enter the command "dotnet watch run" in the terminal and press "Enter"

##### Download Postman:
1. Download and Install the Postman application https://www.postman.com/downloads/
2. Host the server and use Postman to make your HttpRequests.

---
---

### Known Bugs

* When submitting an edit/update the program adds another engineer/machine into the list.

### Support and contact details
Reach out to chy.yoon@gmail.com for support.

## Technologies Used

* Visual Studio Code
* HTML
* CSS
* Bootstrap
* C#
* MVC
* MySQL Workbench
* Entity Framework
* .NET Core

## Resources:

### License

Copyright (c) 2020 ** _Chris Yoon_**

This software is licensed under the MIT license.