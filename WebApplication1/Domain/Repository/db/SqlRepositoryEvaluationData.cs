using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationCore.Data;

namespace WebApplicationCore.Domain.Repository
{
    public class SqlRepositoryEvaluationData : IRepositoryEvaluation
    {
        private CollegeDbContext _context;

        public SqlRepositoryEvaluationData(CollegeDbContext context)
        {
            _context = context;
        }

        public void add(Evaluation evaluation)
        {
            _context.Evaluation.Add(evaluation);
            _context.SaveChanges();
        }

        public List<SelectListItem> student()
        {
            return _context.Students.Select(a => new SelectListItem
            {
                Value = a.id.ToString(),
                Text = a.Name
            }).ToList();
        }

        public List<SelectListItem> course()
        {
            return _context.Courses.Select(c => new SelectListItem
            {
                Value = c.id.ToString(),
                Text = c.Name
            }).ToList();
        }

        public IEnumerable<Evaluation> GetAllEvaluation()
        {
            return _context.Evaluation.Include(c => c.Student)
                                        .Include(c => c.Course)
                                            .OrderBy(c => c.id);
        }

        public Evaluation GetEvaluationById(int id)
        {
            return _context.Evaluation.Include(c => c.Student)
                                        .Include(c => c.Course)
                                            .FirstOrDefault(c => c.id == id);
        }

        public void remove(Evaluation evaluation)
        {
            _context.Evaluation.Remove(evaluation);
            _context.SaveChanges();
        }
    }
}
