cite : https://www.youtube.com/watch?v=9zJn3a7L1uE 
use SwaggerHub website along with this project 
1. Run "dotnet run watch" command and the SwaggerHub website would pop up 
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





<structure for the web API>  

       DTO          DTO        Model  
Client -> Controller -> Service -> Database