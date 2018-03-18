using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain
{
    public class Evaluation
    {
        public int id { get; set; }
        [Required]
        public int Note { get; set; }
        public Student Student { get; set; }
        [Required]
        public int StudentId { get; set; }
        public Course Course { get; set; }
        [Required]
        public int CourseId { get; set; }
    }
}
