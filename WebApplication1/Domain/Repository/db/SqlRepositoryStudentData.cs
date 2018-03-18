using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Data;

namespace WebApplicationCore.Domain.Repository
{
    public class SqlRepositoryStudentData : IRepositoryStudent
    {
        private CollegeDbContext _context;

        public SqlRepositoryStudentData(CollegeDbContext context)
        {
            _context = context;
        }
        public Student add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            return _context.Students.OrderBy(c => c.id);
        }

        public Student GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(c => c.id == id);
        }


    }
}
