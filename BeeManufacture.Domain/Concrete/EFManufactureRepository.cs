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

        public void SaveBHouse(BHouse bhouse)
        {
            if (bhouse.BHouseId == 0)
            {
                context.BHouses.Add(bhouse); 
            }

            else
            {
                BHouse bh = context.BHouses.Find(bhouse.BHouseId);

                if (bh != null)
                {
                    bh.Name = bhouse.Name;
                    bh.BHType = bhouse.BHType;
                    bh.MB_Birth = bhouse.MB_Birth;
                    bh.MB_Kind = bhouse.MB_Kind;
                    bh.StartDate = bhouse.StartDate;
                }
            }
            context.SaveChanges();
        }

        public BHouse DeleteBHouse(int id)
        {
            BHouse bh = context.BHouses.Find(id);
            if (bh != null)
            {
                context.BHouses.Remove(bh);
                context.SaveChanges();
            }
            return bh;
        }

    }
}
