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
    }
}
