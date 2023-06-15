global using AutoMapper;
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
        private readonly IMapper _mapper;
         // got the reference , used to map the Character to GetCharacterDto
         public CharacterService(IMapper mapper)
         {
            _mapper = mapper;
         }
         public async Task<ServiceResponse< List <GetCharacterDto>>> AddCharacter (AddCharacterDto newCharacter)
         {
            // add charcter in the list 
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            // get the maximum id and add 1 to it
            var character = _mapper.Map<Character>(newCharacter);
            character.Id = characters.Max(c => c.Id) + 1;
            characters.Add(character);
            // characters.Add(newCharacter);
            // serviceResponse.Data = characters;

            // characters.Add(_mapper.Map<Character>(newCharacter)); 
            // we need the list of getcharacterdto, so create them in a list using mapper 
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
            return serviceResponse;
         }
         
      
        public async Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();

            try
            {
                var character = await _context.Characters
                    .FirstOrDefaultAsync(c => c.Id == id && c.User!.Id == GetUserId());
                if (character is null)
                    throw new Exception($"Character with Id '{id}' not found.");

                Characters.Remove(character);
                serviceResponse.Data = Characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();

               
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    
         public async Task<ServiceResponse<List <GetCharacterDto>>> GetAllCharacters()
         {
            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)
            var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
            serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDto>(c)).ToList();
      
            return serviceResponse;
         }
         public async Task< ServiceResponse< GetCharacterDto>>   GetCharacterById(int id)
         { 

            // IActionResult return type is approrpriate when multiple ActionResult return types are
            // possible : ex. BadRequest, NotFound,.. OkObjectResult(200)

   
            // FirstOrDefault: returns id if Id == id. Else, returns empty string
            // return characters.FirstOrDefault(c => c.Id == id );
            // Fix the possible argumentnullexception : test out for non existing id 
            
            var serviceResponse = new ServiceResponse<GetCharacterDto>();
            var character = characters.FirstOrDefault(c => c.Id == id );

            // if(character is not null){
            //    return character;
            // }
            // throw new Exception("Character not found");
            // serviceResponse.Data = character;

            // Map the character to GetCharacterDto : source -> target
            serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
            return serviceResponse; 
         }

         public async Task< ServiceResponse< GetCharacterDto>>  UpdateCharacter(UpdateCharacterDto updatedCharacter)
         {
          var serviceResponse = new ServiceResponse<GetCharacterDto>();
          try{
           
           var character = characters.FirstOrDefault(c => c.Id == updatedCharacter.Id);
           if (character is null){
              throw new Exception($"Character with Id '{updatedCharacter.Id}' not found");

           }
          

            // _mapper.Map<Character>(updatedCharacter);
            // need to create a new class in AutoMapperProfile.cs
            _mapper.Map(updatedCharacter, character);
         //   character.Name = updatedCharacter.Name; 
         //   character.HitPoints = updatedCharacter.HitPoints; 
         //   character.Strength = updatedCharacter.Strength;
         //   character.Defense = updatedCharacter.Defense;
         //   character.Intelligence = updatedCharacter.Intelligence;
         //   character.Class = updatedCharacter.Class;

           serviceResponse.Data = _mapper.Map<GetCharacterDto>(character);
          }
          catch(Exception ex){
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
          }
           return serviceResponse;



          }
  }



}