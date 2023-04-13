# Dr. Sillystringz's Factory

#### Engineering and machine tracking for Fidgetech

#### By Kiernan Beattie 

## Technologies Used

* C#
* Dotnet
* Html
* Entity
* MySQL

## Description

* A program for tracking engineers and the machines they are assigned to repair

## Setup/Installation Requirements

1. Open terminal cd to a Appropriate directory enter `git clone https://github.com/kiernan2/Factory.Solution`
2. Enter `dotnet restore` , `dotnet build` and `dotnet tool install --global dotnet-ef --version 3.0.0` in `Same directory/Factory.Solution/Factory`
3. Create a appropriate appsettings.json With a connection string IE
```json
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=kiernan_beattie;uid=root;pwd=YOUR-PASSWORD-HERE;"
    }
}
```
4. Enter `dotnet ef database update` to build the appropriate database
5. Open a terminal and cd to `(Wherever you put the file)/Factory.Solution/Factory`
6. Enter dotnet run
7. Open a browser Go to `http://localhost:5000`


MIT

## Contact Information
Kiernan1994@gmail.com