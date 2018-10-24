using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BeeManufacture.Domain.Entities
{
    public class MB
    {
        [Key]
        public int MB_Id { get; set; }
        public string Name { get; set; }
    }
}
