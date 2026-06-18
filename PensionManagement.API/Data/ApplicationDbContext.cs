using Microsoft.EntityFrameworkCore;
using PensionManagement.API.Models;

namespace PensionManagement.API.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
            {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
