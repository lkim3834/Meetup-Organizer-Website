using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*THIS service file is needed to save the data for.
Without this file, refreshing after POST execute would lose all the newCharcters */
namespace RestAPI_project.Services.CharacterService
{
    public interface ICharacterService
    {
        // Task document : https://dotnettutorials.net/lesson/asynchronous-programming-in-csharp/#:~:text=In%20C%23.NET%2C%20the%20task,NET%20Framework%204.0.
        // Task is used to pass the asynchronous task
        Task< ServiceResponse<List  <Character>>> GetAllCharacters();
        Task<ServiceResponse<Character>> GetCharacterById(int id);
        Task<ServiceResponse<List <Character>>> AddCharacter (Character newCharacter);
    }
}