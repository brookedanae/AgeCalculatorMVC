using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgeCalculator.Models
{
    public class AgeViewModel
    {
        [Display(Name = "Age")]
        [Required]
        [ViewData]
        public int Age { get; set; }

        [Required]
        public string UserName { get; set; }
    }
}
