using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BeeManufacture.Domain.Entities
{
    public class BHType
    {
        [Key]
        public int BHTypeId { get; set; }
        public string Name { get; set; }
        public int QuantityOnManufacture { get; set; }
    }
}
