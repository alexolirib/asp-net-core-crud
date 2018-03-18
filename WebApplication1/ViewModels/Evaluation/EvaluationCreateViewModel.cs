using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.ViewModels
{
    public class EvaluationCreateViewModel
    {
        public List<SelectListItem> nomeStudent { get; set; }
        [Display(Name  = "Escolha o Aluno")]
        public int idStudent { get; set; }
        public List<SelectListItem> nomeCourse { get; set; }
        [Display(Name = "Curso")]
        public int idCourse { get; set; }
        [Display(Name ="Nota")]
        [Required]
        public int Note { get; set; }
    }
}
