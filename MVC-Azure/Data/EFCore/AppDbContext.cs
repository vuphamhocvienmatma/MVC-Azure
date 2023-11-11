using Microsoft.EntityFrameworkCore;
using MVC_Azure.Data.Model;

namespace MVC_Azure.Data.EFCore
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }

    }
}
