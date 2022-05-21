using Example.Models;
using Microsoft.EntityFrameworkCore;


namespace Example.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options)  : base(options)  
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
