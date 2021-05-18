using Microsoft.EntityFrameworkCore;
using RockyNetCoreCourse.Models;

namespace RockyNetCoreCourse.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Category { get; set; }
    }
}