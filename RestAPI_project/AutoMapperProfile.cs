using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RestAPI_project
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // create a character or map into getcharacterDTO 
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}