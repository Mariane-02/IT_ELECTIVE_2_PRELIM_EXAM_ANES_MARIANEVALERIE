using System;

namespace IT_ELECTIVE_2_PRELIM_OOP.Models
{
    public class QuickRecipe : RecipeBase
    {
        public bool IsQuickMeal { get; set; } = true;

        public QuickRecipe() { }

        public QuickRecipe(string title, int prepTimeMinutes, string difficulty, bool isQuickMeal)
            : base(title, prepTimeMinutes, difficulty)
        {
            IsQuickMeal = isQuickMeal;
        }

        public override string GetRecipeInfo() =>
            base.GetRecipeInfo() + $", Quick Meal: {(IsQuickMeal ? "Yes" : "No")}";
    }
}