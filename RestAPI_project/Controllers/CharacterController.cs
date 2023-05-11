
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI_project.Controllers
{
    // indicates that a type and all derived types are used to serve HTTP API responses
    [ApiController]
    // controller is Character, which comes before Controller on the class name
    [Route("api/[controller]")] 
    public class CharacterController: ControllerBase
    {
         // private static List<Character> characters = new List<Character> {
         //    new Character(),
         //    new Character {Id = 1, Name = "Sam"}
         // };
         // command + . to see the more actions
         // Injecting new character service into the controller from ICharacterService.cs file
         private readonly ICharacterService _characterService;
         public CharacterController(ICharacterService characterService)
         {
            _characterService = characterService;
            
         }
         // enables us to send specific HTTP status codes back to the client
         // Character/GetAll => to ignore duplication for Get  
        [HttpGet("GetAll")]
        
         public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
         {
            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)
            return Ok(await _characterService.GetAllCharacters());
         }

         [HttpGet("{id}")]

         // pass the id inside the parameter
         // async Task is used to pass the asynchronous task and await is used to wait for the task to complete
         public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
         {
            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)

   
            // FirstOrDefault: returns id if Id == id. Else, returns empty string
            // return Ok(characters.FirstOrDefault(c => c.Id == id ));
            // return Ok(_characterServssice.GetAllCharacters());
            return Ok( await _characterService.GetCharacterById(id));
         }
         [HttpPost]
         public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> AddCharacter (AddCharacterDto newCharacter)
         {
            // add charcter in the list 

            // characters.Add(newCharacterService.characterService);
            // return Ok(characters );
            return Ok(await _characterService.AddCharacter(newCharacter));
         }
    }
}