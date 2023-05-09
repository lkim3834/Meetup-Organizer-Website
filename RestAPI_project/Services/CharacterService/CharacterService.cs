using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_project.Services.CharacterService
{
    // ICharcterService needed to be added (ICharacterServe.cs)

    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
         };
         public async Task<ServiceResponse< List <Character>>> AddCharacter (Character newCharacter)
         {
            // add charcter in the list 
            var serviceResponse = new ServiceResponse<List<Character>>();

            characters.Add(newCharacter);
            serviceResponse.Data = characters;
            return serviceResponse;
         }

         
         public async Task<ServiceResponse<List <Character>>> GetAllCharacters()
         {
            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)
            var serviceResponse = new ServiceResponse<List<Character>>();
            serviceResponse.Data = characters;
            return serviceResponse;
         }
         public async Task< ServiceResponse< Character >>   GetCharacterById(int id)
         { 

            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)

   
            // FirstOrDefault: returns id if Id == id. Else, returns empty string
            // return characters.FirstOrDefault(c => c.Id == id );
            // Fix the possible argumentnullexception : test out for non existing id 
            var character = characters.FirstOrDefault(c => c.Id == id );
            var serviceResponse = new ServiceResponse<Character>();

            // if(character is not null){
            //    return character;
            // }
            // throw new Exception("Character not found");
            serviceResponse.Data = character;
            return serviceResponse; 
         }

    }
}