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
    public class StudentController : Controller
    {
        private IRepositoryStudent _repositoryStudent;

        public StudentController(IRepositoryStudent repositoryStudent)
        {
            _repositoryStudent = repositoryStudent;
        }


        public IActionResult Index()
        {
            var student = new StudentIndexViewModel();

            student.listStudent = _repositoryStudent.GetAllStudent();

            student.CurrentMensage = "Student";
            return View(student);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _repositoryStudent.GetStudentById(id);
            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                var studentViewModel = new StudentEditModelDelete();

                studentViewModel.idStudent = student.id;
                studentViewModel.nameStudent = student.Name;
                return View(studentViewModel);
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            var student = _repositoryStudent.GetStudentById(id);
            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }
            _repositoryStudent.remove(student);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var student = _repositoryStudent.GetStudentById(id);
            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StudentEditModelAdd model)
        {
            if (ModelState.IsValid)
            {
                var student = new Student();
                student.Name = model.Name;
                student = _repositoryStudent.add(student);
                return RedirectToAction(nameof(Details), new { id = student.id });
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult upDate(int id)
        {
            var student = _repositoryStudent.GetStudentById(id);
            if(student == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var studentViewModel = new StudentEditModelAdd()
            {
                Name = student.Name
            };
            return View(studentViewModel);
        }

        public IActionResult upDate(int id, StudentEditModelAdd model)
        {
            if (ModelState.IsValid)
            {
                var student = _repositoryStudent.GetStudentById(id);
                if(student == null)
                {
                    return RedirectToAction(nameof(Index));
                }
                student.Name = model.Name;
                _repositoryStudent.upDate(student);
                return RedirectToAction(nameof(Details), new { student.id });
            }
            else
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}