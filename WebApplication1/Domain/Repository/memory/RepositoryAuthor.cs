using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{

    class RepositoryAuthor : IRepositoryAuthor
    {

        List<Author> ListAuthors = new List<Author>
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

        public RepositoryAuthor()
        {
        }

        public Author add(Author author)
        {
            author.id = ListAuthors.Max(a => a.id) + 1;
            ListAuthors.Add(author);
            return author;
        }

        public IEnumerable<Author> GetAllAuthor()
        {
            return ListAuthors.OrderBy(c=>c.id);
        }

        public Author GetAuthorById(int id)
        {
            var listAuthor = ListAuthors;

            var authorId = listAuthor.Where(c => c.id == id).FirstOrDefault();

            return authorId;
        }

        public void remove(Author author)
        {
            throw new NotImplementedException();
        }

        public Author upDate(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
