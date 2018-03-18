﻿using System;
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
        public IActionResult Create(StudentEditModel model)
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
    }
}