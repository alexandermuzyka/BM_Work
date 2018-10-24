using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeManufacture.Domain.Entities;

namespace BeeManufacture.Domain.Abstract
{
    public interface IManufactureRepository
    {
        IQueryable<BHType> BHTypes { get; }
        IQueryable<MB> MBs { get; }
        IQueryable<BHouse> BHouses {get;}
    }
}
