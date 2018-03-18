using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{
    public interface IRepositoryStudent
    {
        IEnumerable<Student> GetAllStudent();

        Student GetStudentById(int id);

        Student add(Student author);

        void remove(Student student);
    }
}
