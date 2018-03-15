using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain
{
    public class Course
    {
        public int id { get; set; }
        public String Name { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public List<Evaluation> Evaluation { get; set; }

        public Course()
        {
            Evaluation = new List<Evaluation>();
        }
    }
}
