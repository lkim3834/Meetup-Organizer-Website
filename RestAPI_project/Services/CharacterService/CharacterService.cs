using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI_project.Services.CharacterService
{
    // ICharcterService needed to be added (ICharacterServe.cs)

    public class CharacterService : ICharacterService
    {
        private static List<GetCharacterDto> characters = new List<Character> {
            new Character(),
            new Character {Id = 1, Name = "Sam"}
         };
        private readonly IMapper _mapper;

         public CharacterService(IMapper mapper)
         {
            _mapper = mapper;
            
         }
         public async Task<ServiceResponse< List <GetCharacterDto>>> AddCharacter (AddCharacterDto newCharacter)
         {
            // add charcter in the list 
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();

            // characters.Add(newCharacter);
            // serviceResponse.Data = characters;

            characters.Add(_mapper.Map<Character>(newCharacter));
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
         }

         
         public async Task<ServiceResponse<List <GetCharacterDto>>> GetAllCharacters()
         {
            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters;
      
            return serviceResponse;
         }
         public async Task< ServiceResponse< GetCharacterDto>>   GetCharacterById(int id)
         { 

            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)

   
            // FirstOrDefault: returns id if Id == id. Else, returns empty string
            // return characters.FirstOrDefault(c => c.Id == id );
            // Fix the possible argumentnullexception : test out for non existing id 
            var character = characters.FirstOrDefault(c => c.Id == id );
            var serviceResponse = new ServiceResponse<GetCharacterDto>();

            // if(character is not null){
            //    return character;
            // }
            // throw new Exception("Character not found");
            // serviceResponse.Data = character;

            // Map the character to GetCharacterDto : source -> target
            serviceResonse.Data = _mapper.Map<GetCharacterDto>(character);
            return serviceResponse; 
         }

    }
}