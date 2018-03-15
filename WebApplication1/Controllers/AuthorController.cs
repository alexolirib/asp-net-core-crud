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

        public AuthorController(IRepositoryAuthor  repositoryAuthor)
        {
            _repositoryAuthor = repositoryAuthor;
        }
        public IActionResult Index()
        {
            var author = new AuthorIndexViewModel();
            author.listAuthors = _repositoryAuthor.GetAllAuthor();
            author.searchById = _repositoryAuthor.GetAuthorById(2);
            author.CurrentMessage = "Primeiro busca";
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
    }
}