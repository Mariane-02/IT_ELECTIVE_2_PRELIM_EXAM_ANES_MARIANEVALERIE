using System;
using System.Collections.Generic;
using IT_ELECTIVE_2_PRELIM_OOP.Models;

namespace IT_ELECTIVE_2_PRELIM_OOP.Services
{
    public class Kitchen
    {
        private List<Meal> meals = new();

        public void AddMeal(Meal meal) => meals.Add(meal);

        public List<Meal> GetMeals() => meals;

        public bool RemoveMeal(string name) =>
            meals.RemoveAll(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) > 0;

        protected void PrepareMeal(Meal meal)
        {
            Console.WriteLine($"Preparing {meal.Name}...");
        }

        public string GetKitchenInfo() =>
            $"Kitchen currently has {meals.Count} meal(s).";
    }
}