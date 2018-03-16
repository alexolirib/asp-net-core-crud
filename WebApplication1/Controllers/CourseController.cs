using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore.Domain.Repository;
using WebApplicationCore.ViewModels;

namespace WebApplicationCore.Controllers
{
    public class CourseController : Controller
    {
        private IRepositoryCourse _repositoryCourse;

        public CourseController(IRepositoryCourse repositoryCourse)
        {
            _repositoryCourse = repositoryCourse;
        }

        public IActionResult Index()
        {
            var course = new CourseIndexViewModel();
            course.CurrentMensage = "Todos os Curso";
            course.listCourse = _repositoryCourse.GetAllCourse();
            course.CourseId = _repositoryCourse.GetCourseById(4);
            return View(course);
        }

        public IActionResult details(int id)
        {
            var course = _repositoryCourse.GetCourseById(id);
            if (course == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        public IActionResult create()
        {
            var course = new CourseCreateViewModels();
            var Author = new RepositoryAuthor();
            course.listAuthor = Author.GetAllAuthor();
            return View(course);
        }
    }
}