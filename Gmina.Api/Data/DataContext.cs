using Microsoft.EntityFrameworkCore;
using GminaApi.Entity;

namespace GminaApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<ApplicationEntity> Applications { get; set; }
        public DbSet<ParameterApplicationEntity> ParametersApplication { get; set; }
        public DbSet<UserApplicationEntity> UsersApplications { get; set; }
        public DbSet<UserApplicationValueEntity> UserApplicationValues { get; set; }
        public DbSet<EventEntity> EventEntity { get; set; }
        
    }
}
