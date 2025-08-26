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


**Endpoints**


| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |

Esse é o schema (model) de Tarefa, utilizado para passar para os métodos que exigirem

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```
