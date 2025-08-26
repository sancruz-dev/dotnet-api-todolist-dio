# Project Challenge TodoList - .NET API and Entity Framework

[![.NET](https://img.shields.io/badge/.NET-7.0-512bd4.svg)](https://dotnet.microsoft.com/)
[![Entity Framework](https://img.shields.io/badge/Entity%20Framework-512BD4?logoColor=white)](https://docs.microsoft.com/en-us/ef/)
[![SqlServer](https://img.shields.io/badge/SqlServer-white.svg)](https://www.mysql.com/)
[![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=flat&logo=swagger&logoColor=black)](https://swagger.io/)
## Project Challenge
For this challenge you will need to use your knowledge acquired in the API and Entity Framework module from the .NET track from Dio.

## Context
You need to build a task management system where you can register a list of tasks that will make your routine better organize.

This list of tasks needs to have a CRUD, ie it should allow you to get the records, create, save and delete these records.

Your application should be web API or MVC type, feel free to implement the solution you find most appropriate.

Your main class, the task class, must be as follows:

! [Task class diagram] (diagram.png)

Be sure to generate your migration to update in the database.

## Expected methods
You are expected to create your methods as follows:


** Swagger **


! [Swagger Methods] (swagger.png)


** Endpoints **


| Verb | Endpoint | Parameter | Body |
| --------- | ----------------------------------------------------------------------------------------------------------
| GET | /Task/{id} | ID | N/A |
| Put | /Task/{id} | ID | Schema Task |
| Delete | /Task/{id} | ID | N/A |
| GET | /Task/Obtertodes | N/A | N/A |
| GET | /Task/obtaining | Title | N/A |
| GET | /Task/ObtainPorData | DATE | N/A |
| GET | /Task/Obtain Popstatus | Status | N/A |
| Post | /Task | N/A | Schema Task |

This is the task schema (model), used to move on to the methods that require

`` `Json
{
  "ID": 0,
  "Title": "String",
  "Description": "String",
  "DATE": "2022-06-08T01: 31: 07.056Z",
  "Status": "Pending"
}
`` `

