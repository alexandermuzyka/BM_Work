using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeeManufacture.Domain.Entities;

namespace BeeManufacture.WebUI.Models
{
    public class TotalBeeModel
    {
        public IEnumerable<BHouse> BHouses { get; set; }
        public IEnumerable<BHType> BHTypes { get; set; }
        public IEnumerable<MB> MBs { get; set; }
    }
}