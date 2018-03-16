using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain
{
    public class Author
    {
        public int id { get; set; }
        [Display(Name="Nome Author ")]
        [Required,MaxLength(80)]
        public String Name { get; set; }
        [Display(Name="Idade")]
        [Required]
        public int Age { get; set; }
        public List<Course> Course { get; set; }

        public Author()
        {
            Course = new List<Course>();
        }
    }
}
