using System.Diagnostics.Metrics;
using Microsoft.EntityFrameworkCore;

namespace Domain.AppState
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Measurement> Measurements { get; set; }
    }
}
