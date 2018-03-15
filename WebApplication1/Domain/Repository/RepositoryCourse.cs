using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{

    class RepositoryCourse : IRepositoryCourse
    {
        List<Course> courses = new List<Course>
        {
            new Course
            {
                id = 1,
                Name = "c# Básico",
                AuthorId = 1
            },
            new Course
            {
                id = 1,
                Name = "c# Intermediário",
                AuthorId = 1
            },
            new Course
            {
                id = 1,
                Name = "c# Avançado",
                AuthorId = 1
            },
            new Course
            {
                id = 1,
                Name = "java",
                AuthorId = 2
            }
        };


        public IEnumerable<Course> GetAllCourse()
        {
            return courses.OrderBy(c => c.id);
        }

        public Course GetCourseById(int id)
        {
            return courses.FirstOrDefault(c => c.id == id);
        }
    }
}
