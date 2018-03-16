using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{
    public interface IRepositoryAuthor
    {
        IEnumerable<Author> GetAllAuthor();

        Author GetAuthorById(int id);

        Author Cadastrar(Author author);
    }

}
