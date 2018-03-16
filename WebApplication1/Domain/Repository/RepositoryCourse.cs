using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{

    class RepositoryCourse : IRepositoryCourse
    {
        IEnumerable<Course> courses = new List<Course>
        {
            new Course
            {
                id = 1,
                Name = "c# Básico",
                AuthorId = 1
            },
            new Course
            {
                id = 2,
                Name = "c# Intermediário",
                AuthorId = 1
            },
            new Course
            {
                id = 3,
                Name = "c# Avançado",
                AuthorId = 1
            },
            new Course
            {
                id = 4,
                Name = "Java",
                AuthorId = 2
            }
        };


        public IEnumerable<Course> GetAllCourse()
        {
            return courses.OrderBy(c => c.id);
        }

        public Course GetCourseById(int id)
        {
            var author = new RepositoryAuthor();
            var listAuthor = author.GetAllAuthor();

            return courses.FirstOrDefault(c => c.id == id);
            
        }
    }
}
