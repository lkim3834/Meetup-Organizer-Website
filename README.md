# Meetup-Organizer-Website

A website, event organization platform, meant to make it easier for people to create events and collaborate with others to set them up

# What I Learned

* Send notifications and emails to people invited to the event using Node.js as the backend and HTML/CSS as the frontend
* Deploy a complete web-serving stack through google cloud platform using SQL language
* How to implement Data-Transfer-Objects (DTOs) 
* Asynchronous (occur independently) programming in C# 


# Summary for Web API 

* Web API with all CRUD operations
* HTTP request methods GET, POST, PUT & DELETE
* Model-View Controller (MVC) pattern 
* Real World concepts & practices 
* Dependency injection, async/await, DTOs 

# HTTP request methods GET, POST, PUT & DELETE
<img width="1436" alt="Screenshot 2023-06-16 at 9 48 55 AM" src="https://github.com/lkim3834/Meetup-Organizer-Website/assets/63019945/741bfeca-d4b7-41a7-ad2f-72c45c7401ed">

# Web API using .NET 7 
reference cite : https://www.youtube.com/watch?v=9zJn3a7L1uE 
page link : http://localhost:5121/swagger/index.html 
use SwaggerHub website along with this project 
1. Run "dotnet run watch" command and the SwaggerHub website would pop up 
    - whenever "Address already in use" error appears, do
        1. "lsof -i : <port number>"
        2. "kill -9 <process number>"s
2. Inside CharacterController.cs file, 
    - Get() function would get all character. 
    - GetSingle() function would get specific character with c.Id == id. SwaggerHub would require you to enter the id  (try 0 for Frodo and 1 for Sam)
    - AddCharacter() __ meant for the POST. try changing the name and id and execute on Swagger.
HTTP Request Methods ( defined )
- GET, POST, PUT, DELETE
- GET (Read): requests a representation of the specified resource
- POST (Create): submit an entity to the specified resource, often causing a change in state/side effects on the server (back-end)
- PUT (Update): replaces all current representations of the target resource with the request payload
- DELETE (delete): deletes the specified resource
3. USe AutoMapper 
    - why do we need AutoMapper?
        a. To convert List<Character> to List<GetCharacterDto>
        b. Map the objects by creating a new instance of the necessary class
    - How to use them 
        a. install automapper through command (https://automapper.org/)
        b. Add it on Program.cs file and CharacterService.cs

# Web API using Microft entity frameworkcore
* Install the package ( https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)
* command : - dotnet add package Microsoft.EntityFrameworkCore
            - dotnet add package Microsoft.EntityFrameworkCore.SQLServer
            - dotnet add package Microsoft.EntityFrameworkCore.Design
* install tool command :
            - dotnet tool update --global dotnet-ef
* Azure Data Studio :

  - add a new query to add new data to the tables
  - test it on the website
 ![sql_view_WEBAPI](https://github.com/lkim3834/Meetup-Organizer-Website/assets/63019945/2a486b35-38f0-44a3-a558-3d37a35c407b)
 



# Structure for the Web API 

       DTO          DTO        Model  
Client -> Controller -> Service -> Database
