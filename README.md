# ToDo API

##### basic to do list API built with Visual Studio 17, C#, and .NET Core 2.1  09/2004/18

## By Sara Hamilton

# Description
This to do list API was built following the tutorial at https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.1#get-to-do-items

## Functionality

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

  * _Clone the github respository_
  ```
  $ git clone https://github.com/Sara-Hamilton/ToDoApi
  ```

* _Move into the directory_
```
$ cd GummiBears
```
*  _Restore the program_

 ```
 $ dotnet restore
 ```
* _Move one layer deeper into the directory_
```
$ cd GummiBears
```
*  _Setup the database_

 ```
 $ dotnet ef database update --context GummiDbContext
```
*  _Run the program_
```
$ dotnet run
```
## Testing

* _Move two layers into the directory_
```
$ cd GummiBears/GummiBears
```
*  _Setup the testing database_

 ```
 $ dotnet ef database update --context TestDbContext
```
* _Open project solution in Visual Studio_

*  _Run the tests_

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