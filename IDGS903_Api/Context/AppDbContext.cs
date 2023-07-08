using IDGS903_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace IDGS903_Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Alumnos> Alumnos { get; set; }
    }
}
