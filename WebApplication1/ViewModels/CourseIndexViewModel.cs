using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class CourseIndexViewModel
    {
        public IEnumerable<Course> listCourse { get; set; }
        public Course CourseId { get; set; }
        public String CurrentMensage { get; set; }
    }
}
