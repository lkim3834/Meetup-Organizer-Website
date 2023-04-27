// For JsonConverter
using System.Text.Json.Serialization;
namespace RestAPI_project.Models
{
    // enum became the array of [knight, mage, cleric] from [1,2,3] by adding JsonCovnerter
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3 
    }
}