using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public Course add(Course course)
        {
            throw new NotImplementedException();
        }

        public Course edit(Course course)
        {
            throw new NotImplementedException();
        }

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

        public void remove(Course course)
        {
            throw new NotImplementedException();
        }

        public List<SelectListItem> SelectListItemAuthor()
        {
            throw new NotImplementedException();
        }
    }
}
