using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*THIS service file is needed to save the data for.
Without this file, refreshing after POST execute would lose all the newCharcters */
namespace RestAPI_project.Services.CharacterService
{
    public interface ICharcterService
    {
        List <Character> GetAllCharacters();
        Character  GetCharacterById(int id);
        List <Character> AddCharacter (Character newCharacter);
    }
}