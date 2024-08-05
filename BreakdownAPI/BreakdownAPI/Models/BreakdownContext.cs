using Microsoft.EntityFrameworkCore;

namespace BreakdownAPI.Models
{
    public class BreakdownContext : DbContext
    {
        public BreakdownContext(DbContextOptions<BreakdownContext> options) : base(options)
        {
        }

        public DbSet<Breakdown> Breakdowns { get; set; }
    }
}