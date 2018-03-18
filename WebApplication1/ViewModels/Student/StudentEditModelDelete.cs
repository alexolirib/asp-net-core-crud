using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.ViewModels
{
    public class StudentEditModelDelete
    {
        [Required]
        public int idStudent { get; set; }
        public String nameStudent { get; set; }
    }
}
