using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class CourseDetailsViewModel
    {
        public Course course { get; set; }
        public Author authorCurso { get; set; }
    }
}
