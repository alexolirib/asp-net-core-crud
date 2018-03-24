using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{
    public interface IRepositoryCourse
    {
        IEnumerable<Course> GetAllCourse();

        Course GetCourseById(int id);

        Course add(Course course);

        void remove(Course course);

        List<SelectListItem> SelectListItemAuthor();

        Course edit(Course course);
    }
}
