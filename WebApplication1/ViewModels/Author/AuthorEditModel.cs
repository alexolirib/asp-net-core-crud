using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.ViewModels
{
    public class AuthorEditModel
    {
        [Required, MaxLength(80)]
        public String Name { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
