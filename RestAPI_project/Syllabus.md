1. Tools required for the course (Visual Studio Code & .NET SDK),
2. Creating a new Web API,
3. Making the first API call,
4. Setting up a Git repository and .gitignore file,
5. Introduction to Web API,
6. Explaining the Model-View-Controller (MVC) pattern,
7. Creating new models,
8. Creating a new controller and retrieving a new character using GET,
9. Using attribute routing,
10. Using routing with parameters,
11. Explanation of HTTP request methods,
12. Adding a new character using POST,
13. Best practices for structuring a Web API,
14. Creating a character service,
15. Handling possible ArgumentNullException,
16. Using asynchronous calls,
    - add async Task<> for return value before function name 
    - add await for return value inside function
17. Proper service response using generics,
    - leave success or exception for the result (front end would react)
    - create a new ServiceResponse.cs file inside Models repository 
    - modify the return type of characterservice and Icharacterservice methods (add <ServiceResponse>)

18. Explanation of Data-Transfer-Objects (DTOs),
    - receiving characters from the server and sending a new character to the server.
    - add getcharacterdto and addcharacterdto files in Dtos/Character
    - change character -> getcharacterdto or addcharcterdto 
19. Introduction to AutoMapper,
    - put automapper inside characterservice.cs file 
    - add profile to all the mapper on AutoMapperProfile.cs file
    - issue : not being able to update the id as we POST --> pass in the argument of assigning id to max +1 inside add character function 
20. Modifying a character using PUT,
21. Modifying a character using AutoMapper,
22. Deleting a character,
23. Summary of Web API,
24. Introduction to Entity Framework 7,
25. Explanation of Object-Relational-Mapping & Code-First Migration,
26. Installing Entity Framework 7,
27. Installing SQL Server Express (with Management Studio),
28. Implementing the DataContext,
29. Connection string and adding the DbContext,
30. Implementing GET methods.
