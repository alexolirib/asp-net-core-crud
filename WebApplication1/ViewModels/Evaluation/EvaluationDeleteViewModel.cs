using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class EvaluationDeleteViewModel
    {
        public int idEvaluation { get; set; }
        public String NomeStudent { get; set; }
        public String NomeCourse { get; set; }
    }
}
