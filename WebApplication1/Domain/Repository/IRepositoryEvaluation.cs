using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.Domain.Repository
{
    public interface IRepositoryEvaluation
    {
        IEnumerable<Evaluation> GetAllEvaluation();

        Evaluation GetEvaluationById(int id);

        void add(Evaluation evaluation);

        void remove(Evaluation evaluation);

        List<SelectListItem> student();

        List<SelectListItem> course();
    }
}
