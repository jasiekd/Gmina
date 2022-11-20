using Microsoft.EntityFrameworkCore;
using Gmina_Api.Entity;

namespace Gmina_Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<UserEntity> Users { get; set; }



    }
}
