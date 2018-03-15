using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{

    class RepositoryAuthor : IRepositoryAuthor
    {

        List<Author> authors = new List<Author>
            {
                new Author
                {
                    id = 1,
                    Name = "Scott",
                    Age = 23
                },
                new Author
                {
                    id = 2,
                    Name = "Deborah",
                    Age = 29
                },
                new Author
                {
                    id = 3,
                    Name = "João",
                    Age = 39
                },
                new Author
                {
                    id = 4,
                    Name = "Davi",
                    Age = 900
                }

                };

        public IEnumerable<Author> GetAllAuthor()
        {
            return authors.OrderBy(c=>c.id);
        }

        public Author GetAuthorById(int id)
        {
            var listAuthor = authors;

            var authorId = listAuthor.Where(c => c.id == id).FirstOrDefault();

            return authorId;
        }
    }
}
