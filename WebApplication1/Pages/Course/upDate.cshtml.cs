using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationCore.Domain;
using WebApplicationCore.Domain.Repository;

namespace WebApplicationCore.Pages
{
    public class upDateModel : PageModel
    {
        private IRepositoryCourse _repositoryCourse;

        //esse atributo faz com que a informações seja vinculada entre as propriedades
        [BindProperty]
        public Course course { get; set; }
        public List<SelectListItem> ListAuthor { get; set; }

        public upDateModel(IRepositoryCourse repositoryCourse)
        {
            _repositoryCourse = repositoryCourse;
        }


        public IActionResult OnGet(int id)
        {
            course = _repositoryCourse.GetCourseById(id);
            if (course == null)
            {
                return RedirectToAction("Index", "Course");
            }
            else
            {
                ListAuthor = _repositoryCourse.SelectListItemAuthor();
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {

                _repositoryCourse.edit(course);
                return RedirectToAction("details", "Course", new {course.id });
            }
            else
            {
                return RedirectToAction("Index", "Course");
            }
        }
    }
}