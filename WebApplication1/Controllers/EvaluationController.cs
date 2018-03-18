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
    public class EvaluationController : Controller
    {
        private IRepositoryEvaluation _repositoryEvaluation;

        public EvaluationController(IRepositoryEvaluation repositoryEvaluation)
        {
            _repositoryEvaluation = repositoryEvaluation;
        }
        public IActionResult Index()
        {
            var evaluation = _repositoryEvaluation.GetAllEvaluation();
            var evaluationViewModel = new EvaluationIndexViewModel();
            evaluationViewModel.MensgemAtual = "Evaluation";
            evaluationViewModel.ListEvaluation = evaluation; 
            return View(evaluationViewModel);
        }

        [HttpGet]
        public IActionResult create()
        {
            var evaluation = new EvaluationCreateViewModel();
            evaluation.nomeCourse = _repositoryEvaluation.course();
            evaluation.nomeStudent = _repositoryEvaluation.student();

            return View(evaluation);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(EvaluationCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var evaluation = new Evaluation();
                evaluation.Note = model.Note;
                evaluation.CourseId = model.idCourse;
                evaluation.StudentId = model.idStudent;
                _repositoryEvaluation.add(evaluation);

                return RedirectToAction(nameof(Index));
            }
            else {
                var evaluation = new EvaluationCreateViewModel();
                evaluation.nomeCourse = _repositoryEvaluation.course();
                evaluation.nomeStudent = _repositoryEvaluation.student();

                return View(evaluation);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var evaluation = _repositoryEvaluation.GetEvaluationById(id);
            if(evaluation == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var evaluationViewModel = new EvaluationDeleteViewModel()
            {
                idEvaluation = evaluation.id,
                NomeCourse = evaluation.Course.Name,
                NomeStudent = evaluation.Student.Name
            };

            return View(evaluationViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCongirm(int id)
        {
            var evaluation = _repositoryEvaluation.GetEvaluationById(id);
            if(evaluation == null)
            {
                return Redirect(nameof(Index));
            }
            _repositoryEvaluation.remove(evaluation);
            return RedirectToAction(nameof(Index));
        }
    }
}