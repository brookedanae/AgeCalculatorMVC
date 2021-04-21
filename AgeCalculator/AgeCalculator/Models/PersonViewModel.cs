using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeCalculator.Models
{
    public class PersonViewModel
    {
        [ViewData]
        public int Age { get; set; }

        public string UserName { get; set; }

        [ViewData]
        public bool CanDrink { get; set; }

        [ViewData]
        public bool CanDrive { get; set; }
    }
}
