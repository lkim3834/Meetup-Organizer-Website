using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RestAPI_project.Models
{
    public class ServiceResponse<T>
    {
        public T? Data{get;set;}

        public bool Success {get;set;} = true;
        // to handle the case of throwing exceptions
        public string Message {get;set;} = string.Empty;
    }
}