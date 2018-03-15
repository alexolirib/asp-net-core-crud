using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain
{
    public class Evaluation
    {
        public int id { get; set; }
        public int Note { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
