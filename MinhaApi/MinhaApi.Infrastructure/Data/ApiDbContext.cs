using Microsoft.EntityFrameworkCore;
using MinhaApi.Domain.AggregatesModel;
using MinhaApi.Domain.Seedwork;

namespace MinhaApi.Infrastructure.Data
{
    public class ApiDbContext : DbContext, IUnitOfWork
    {
        public DbSet<User> Users { get; set; }
       
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApiDbContext).Assembly);
        }
    }
}
