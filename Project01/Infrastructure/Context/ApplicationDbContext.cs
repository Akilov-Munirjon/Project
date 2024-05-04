using System.Reflection;
using Project01.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Project01.Domain.Common.BaseEntities;

namespace Project01.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Disk> Disks { get; set; }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<DiskType> DiskTypes { get; set; }
        public DbSet<TireType> TireTypes { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ServiceEquipment> ServiceEquipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var changeEntities = ChangeTracker.Entries<BaseEntity>();

            foreach (var entity in changeEntities)
            {
                if (entity.State == EntityState.Added)
                {
                    entity.Entity.CreatedAt = DateTime.Now;
                }
                else if (entity.State == EntityState.Modified)
                {
                    entity.Entity.ModifiedAt = DateTime.Now;
                }
            }

            var result = await base.SaveChangesAsync(cancellationToken);

            return result;
        }
    }
}
