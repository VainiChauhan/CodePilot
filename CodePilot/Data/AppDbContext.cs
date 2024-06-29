using Microsoft.EntityFrameworkCore;
using CodePilot.Models;

namespace CodePilot.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CodeSubmission> CodeSubmissions { get; set; }
    }
}
