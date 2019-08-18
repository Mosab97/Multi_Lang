using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lang.Models
{
    public class Student
    {
        public int id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "req")]
        public string Name { get; set; }

    }
}
