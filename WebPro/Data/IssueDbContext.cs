using WebPro.Model;
using Microsoft.EntityFrameworkCore;

namespace WebPro.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext>options) : base (options)
        {
            
        }
        public DbSet<Issue> Issues { get; set; }
    }
}
