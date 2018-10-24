using System.Data.Entity;
using BeeManufacture.Domain.Entities;

namespace BeeManufacture.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<BHouse> BHouses { get; set; }
        public DbSet<BHType> BHTypes { get; set; }
        public DbSet<MB> MBs { get; set; }
    }
}
