using System;
using System.Collections.Generic;
using System.Linq;
using IT_ELECTIVE_2_PRELIM_OOP.Models;

namespace IT_ELECTIVE_2_PRELIM_OOP.Services
{
    public class RecipeBook
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        private List<MealRecipe> recipes = new();

        public RecipeBook(string name) : this(name, 10) { }
        public RecipeBook(string name, int capacity) => (Name, Capacity) = (name, capacity);

        public void AddRecipe(MealRecipe recipe)
        {
            if (recipes.Count < Capacity) recipes.Add(recipe);
        }

        public List<MealRecipe> Search(string name) =>
            recipes.Where(r => r.Title.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

        public List<MealRecipe> Search(string name, string category) =>
            recipes.Where(r => r.Title.Contains(name, StringComparison.OrdinalIgnoreCase) &&
                                r.Category.Contains(category, StringComparison.OrdinalIgnoreCase)).ToList();

        public List<MealRecipe> Search(int prepTimeMinutes) =>
            recipes.Where(r => r.PrepTimeMinutes == prepTimeMinutes).ToList();

        public List<MealRecipe> GetRecipes() => recipes;
    }
}