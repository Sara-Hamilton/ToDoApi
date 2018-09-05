# ToDo API

This is a basic to do list API built with Visual Studio 17, C#, and .NET Core 2.1 on 09/04/18

## By Sara Hamilton

# Description
This to do list API was built following the tutorial at https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1#get-to-do-items

## Functionality
This is a basic To Do List that can be accessed and viewed as an API or as a web app.  The app can only be run and viewed locally.  The intent is to deploy the API using Azure in the future so that it can be accessed by anyone.  

### Model
* ToDoItem
  * Id
  * Name
  * IsComplete

## Technologies Used
* HTML
* CSS
* Visual Studio
* C#
* .NET Core 2.1

## Prerequisites

* Visual Studio 2017 version 15.7.3 or later with the following workloads:
	* ASP.NET and web development https://www.microsoft.com/net/download
	* .NET Core cross-platform development
* .NET Core 2.1 SDK or later https://www.microsoft.com/net/download

## Run the Application

* _Clone the github repository_
  ```
  $ git clone https://github.com/Sara-Hamilton/ToDoApi
  ```
* _Open the project solution in Visual Studio_

* _Press ctrl + F5 to run the program_

* _View the program in JSON format at https://localhost:44350/api/todo (your port may be different - view Visual Studio logs to determine correct ports)_

* _Edit the todo list using GET, POST, PUT, and DELETE requests with postman_
  * see https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1#get-to-do-items for details.

* _View the program in JavaScript at http://localhost:51866 (your port may be different - view Visual Studio logs to determine correct ports)_


### License

*MIT License*

Copyright (c) 2018 **_Sara Hamilton_**

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
