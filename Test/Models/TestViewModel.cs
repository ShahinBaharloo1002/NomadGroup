using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class TestViewModel
    {
        [Required]
        [Display(Name = "Input")]
        public int input { get; set; }

    }
}