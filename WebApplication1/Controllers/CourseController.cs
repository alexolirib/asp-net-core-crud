using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore.Domain;
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
            course.listCourse = _repositoryCourse.GetAllCourse();
            course.CurrentMensage = "Course";
            return View(course);
        }

        public IActionResult details(int id)
        {
            var courseViewModel = new CourseDetailsViewModel();
            var course = _repositoryCourse.GetCourseById(id);
            if (course == null)
            {
                return RedirectToAction(nameof(Index));
            }
            courseViewModel.course = course;
            courseViewModel.authorCurso = course.Author;

            return View(courseViewModel);
        }

        [HttpGet]
        public IActionResult create()
        {
            var course = new CourseCreateViewModels();
            course.authorsList = _repositoryCourse.SelectListItemAuthor();
            return View(course);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(CourseCreateViewModels model)
        {
            if (ModelState.IsValid)
            {
                var course = new Course();
                course.Name = model.Name;
                course.AuthorId = model.AuthorId;
                course = _repositoryCourse.add(course);
                return RedirectToAction(nameof(details), new { course.id });
            }
            else
            {
                var course = new CourseCreateViewModels();
                course.authorsList = _repositoryCourse.SelectListItemAuthor();
                return View(course);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var course = _repositoryCourse.GetCourseById(id);
            if(course == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var courseViewModel = new CourseDeleteViewModel()
            {
                idCourse = course.id,
                NomeCourse = course.Name
            };
            return View(courseViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            var course = _repositoryCourse.GetCourseById(id);
            if(course == null)
            {
                return RedirectToAction(nameof(Index));
            }
            _repositoryCourse.remove(course);
            return RedirectToAction(nameof(Index));
        }
    }
}