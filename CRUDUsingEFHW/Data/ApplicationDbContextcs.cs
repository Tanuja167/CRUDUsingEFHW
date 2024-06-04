using CRUDUsingEFHW.Models;
using Microsoft.EntityFrameworkCore;
 
namespace CRUDUsingEFHW.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}
