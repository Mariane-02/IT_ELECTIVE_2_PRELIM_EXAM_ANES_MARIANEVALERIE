using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_OOP.Interfaces
{
    public interface IRecipeSearchable
    {
        string SearchCriteria { get; }

        bool MatchesSearch(string searchTerm);
    }
}
