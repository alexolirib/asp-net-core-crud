using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.ViewModels
{
    public class AuthorDeleteModel
    {
        [Required]
        public String Name { get; set; }
        [Required]
        public int age { get; set; }
    }
}
