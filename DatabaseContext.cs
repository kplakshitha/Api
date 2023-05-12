using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<Add> Adds { get; set; }
    }
}
