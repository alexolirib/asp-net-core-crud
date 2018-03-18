using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class CourseDeleteViewModel
    {
        public int idCourse { get; set; }
        public String NomeCourse { get; set; }
    }
}
