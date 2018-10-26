﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace BeeManufacture.Domain.Entities
{
    public class BHouse
    {
        [HiddenInput(DisplayValue = false)]
        public int BHouseId { get; set; }
        [Required(ErrorMessage = "Please, enter BeeHouse name")]
        public int Name { get; set; }
        [Required(ErrorMessage = "Please, choose BHType")]
        public int BHType { get; set; }
        public int MB_Kind { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime MB_Birth { get; set; }
    }
}
