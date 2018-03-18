using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class CourseCreateViewModels
    {
        public IEnumerable<SelectListItem> authorsList { get; set; }
        [Display(Name = "Professor")]
        [Required]
        public int AuthorId { get; set; }
        [Display(Name = "Nome do Curso")]
        [Required, MaxLength(80)]
        public String Name { get; set; }
    }
}
