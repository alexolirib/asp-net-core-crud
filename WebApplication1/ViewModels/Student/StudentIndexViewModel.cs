using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class StudentIndexViewModel
    {
        public IEnumerable<Student> listStudent { get; set; }
        public int idStudent { get; set; }
        public String CurrentMensage { get; set; }
    }
}
