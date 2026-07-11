using System;
using IT_ELECTIVE_2_PRELIM_OOP.Interfaces;

namespace IT_ELECTIVE_2_PRELIM_OOP.Models
{
    public class MealRecipe : RecipeBase, IRecipeSearchable
    {
        public string Category { get; set; } = "";
        public string Area { get; set; } = "";

        public MealRecipe() { }

        public MealRecipe(string title, int prepTimeMinutes, string difficulty, string category, string area)
            : base(title, prepTimeMinutes, difficulty)
        {
            Category = category;
            Area = area;
        }

        public override string GetRecipeInfo() =>
            base.GetRecipeInfo() + $", Category: {Category}, Area: {Area}";

        public string SearchCriteria => Title;

        public bool MatchesSearch(string searchTerm) =>
            Title.Contains(searchTerm, StringComparison.OrdinalIgnoreCase);
    }
}