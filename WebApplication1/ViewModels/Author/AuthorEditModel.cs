using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.ViewModels
{
    public class AuthorEditModel
    {
        [Display(Name = "Name")]
        [Required, MaxLength(80)]
        public String Name { get; set; }
        [Display(Name ="Age")]
        [Required]
        public int Age { get; set; }
    }
}
