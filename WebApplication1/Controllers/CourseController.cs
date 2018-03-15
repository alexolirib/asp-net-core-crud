using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCore.Domain.Repository;

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
            var course = _repositoryCourse.GetAllCourse(); 
            return View();
        }
    }
}