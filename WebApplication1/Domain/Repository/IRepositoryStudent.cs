using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{
    interface IRepositoryStudent
    {
        List<Author> GetAllStudent();

        Author GetStudentById(int id);
    }
}
