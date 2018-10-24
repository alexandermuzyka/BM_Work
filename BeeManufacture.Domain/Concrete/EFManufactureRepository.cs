using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeManufacture.Domain.Abstract;
using BeeManufacture.Domain.Entities;

namespace BeeManufacture.Domain.Concrete
{
    public class EFManufactureRepository : IManufactureRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<BHType> BHTypes { get { return context.BHTypes; } }
        public IQueryable<MB> MBs { get { return context.MBs; } }
        public IQueryable<BHouse> BHouses { get { return context.BHouses; } }
    }
}
