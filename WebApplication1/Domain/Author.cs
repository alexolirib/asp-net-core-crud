using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain
{
    public class Author
    {
        public int id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public List<Course> Course { get; set; }

        public Author()
        {
            Course = new List<Course>();
        }
    }
}
