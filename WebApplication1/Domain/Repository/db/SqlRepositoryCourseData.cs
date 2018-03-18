using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Data;

namespace WebApplicationCore.Domain.Repository
{
    public class SqlRepositoryCourseData : IRepositoryCourse
    {
        private CollegeDbContext _context;

        public SqlRepositoryCourseData(CollegeDbContext context)
        {
            _context = context;
        }

        public Course add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public IEnumerable<Course> GetAllCourse()
        {
            return _context.Courses.OrderBy(c => c.id).ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.Include(a => a.Author)
                                       .FirstOrDefault(c => c.id == id);
        }

        public void remove(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }

        public List<SelectListItem> SelectListItemAuthor()
        {
            return _context.Authors.Select(a => new SelectListItem()
            {
                Value = a.id.ToString(),
                Text = a.Name
            }).ToList();
        }
    }
}
