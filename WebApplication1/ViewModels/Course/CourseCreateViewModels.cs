using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class CourseCreateViewModels
    {
        public IEnumerable<Author> listAuthor { get; set; }
        public Course course { get; set; }
    }
}
