using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BeeManufacture.Domain.Entities
{
    public class BHouse
    {      
        public int BHouseId { get; set; }        
        public int Name { get; set; }
        public int BHType { get; set; }
        public int MB_Kind { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime MB_Birth { get; set; }
    }
}
