using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace RestAPI_project.Data
{
    public class DataContext : DbContext
    {
        // constructer
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        // DB set  : able to query and save rpg character. name of the corresponding database table
        public DbSet<Character> Characters => Set<Character>();
    }
}