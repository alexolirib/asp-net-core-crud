using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationCore.Domain;

namespace WebApplicationCore.ViewModels
{
    public class EvaluationIndexViewModel
    {
        public String MensgemAtual { get; set; }
        public IEnumerable<Evaluation> ListEvaluation { get; set; }
    }
}
