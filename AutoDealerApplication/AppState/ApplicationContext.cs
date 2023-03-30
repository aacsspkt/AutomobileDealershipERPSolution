using System.Diagnostics.Metrics;
using AutoDealerApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoDealerApplication.AppState
{
    public class ApplicationContext: DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public DbSet<Measurement> Measurements { get; set; }
    }
}
