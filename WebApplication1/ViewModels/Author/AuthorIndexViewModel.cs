using System;
using System.Collections.Generic;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class AuthorIndexViewModel
    {
        public IEnumerable<Author> listAuthors { get; set; }
        public Author searchById { get; set; }
        public String CurrentMessage { get; set; }
    }
}
