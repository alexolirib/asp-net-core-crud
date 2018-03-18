using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain
{
    public class Course
    {
        public int id { get; set; }
        [Required, MaxLength(80)]
        public String Name { get; set; }
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public List<Evaluation> Evaluation { get; set; }

        public Course()
        {
            Evaluation = new List<Evaluation>();
        }
    }
}
