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
    public class AuthorController : Controller
    {
        private IRepositoryAuthor _repositoryAuthor;

        public AuthorController(IRepositoryAuthor repositoryAuthor)
        {
            _repositoryAuthor = repositoryAuthor;
        }
        public IActionResult Index()
        {
            var author = new AuthorIndexViewModel();
            author.listAuthors = _repositoryAuthor.GetAllAuthor();
            author.CurrentMessage = "Authors";
            return View(author);
        }

        public IActionResult details(int id)
        {
            var author = _repositoryAuthor.GetAuthorById(id);
            if (author == null)
            {
                //return NotFound(); - aparece erro 404
                //return RedirectToAction("Index"); redirecionar para index quando for null
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        [HttpGet]
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult create(AuthorEditModel model)
        {//validação do servidor
            if (ModelState.IsValid)
            {
                var newAuthor = new Author();
                newAuthor.Name = model.Name;
                newAuthor.Age = model.Age;
                newAuthor = _repositoryAuthor.add(newAuthor);

                //forma errada pois  quando atualizava a tela salva novamente return View("details", newAuthor);
                return RedirectToAction(nameof(details), new { id = newAuthor.id });//é preciso um objeto
            }
            else
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            Author author = _repositoryAuthor.GetAuthorById(id);
            if (author == null)
            {
                return RedirectToAction(nameof(Index));
            }
            var authorViewModel = new AuthorDeleteModel()
            {
                Name = author.Name,
                age = author.Age
            };

            return View(authorViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id)
        {
            Author author = _repositoryAuthor.GetAuthorById(id);
            if(author == null)
            {
                return RedirectToAction(nameof(Index));
            }
            _repositoryAuthor.remove(author);
            return RedirectToAction(nameof(Index));
        }
    }
}