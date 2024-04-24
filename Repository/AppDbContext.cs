using Microsoft.EntityFrameworkCore;
using WebApplication3.Model;
using WebApplication3.Model.AuthApp;

namespace WebApplication3.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            Database.EnsureCreated();
        }

        public DbSet<Movie>? Movies { get; set; }
        public DbSet<AuthUser>? AuthUsers { get; set; }
    }
}