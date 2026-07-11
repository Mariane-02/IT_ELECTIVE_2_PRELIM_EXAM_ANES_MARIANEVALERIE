using System;
using IT_ELECTIVE_2_PRELIM_OOP.Models;
using IT_ELECTIVE_2_PRELIM_OOP.Services;

Console.WriteLine("======================================");
Console.WriteLine("   IT ELECTIVE 2 - OOP PRACTICE");
Console.WriteLine("======================================");

// Create a recipe book
RecipeBook recipeBook = new RecipeBook("My Recipe Book");

// Create a recipe
MealRecipe recipe = new MealRecipe(
    "Chicken Adobo",
    45,
    "Easy",
    "Main Course",
    "Filipino"
);

// Add recipe to the recipe book
recipeBook.AddRecipe(recipe);

// Display recipe information
Console.WriteLine("\nRecipe Information:");
Console.WriteLine(recipe.GetRecipeInfo());

// Search by name
Console.WriteLine("\nSearch by Name:");
foreach (var item in recipeBook.Search("Chicken"))
{
    Console.WriteLine(item.Title);
}

// Search by name and category
Console.WriteLine("\nSearch by Name and Category:");
foreach (var item in recipeBook.Search("Chicken", "Main"))
{
    Console.WriteLine(item.Title);
}

// Search by preparation time
Console.WriteLine("\nSearch by Preparation Time:");
foreach (var item in recipeBook.Search(45))
{
    Console.WriteLine(item.Title);
}

// Kitchen demonstration
Kitchen kitchen = new Kitchen();

Meal meal = new Meal
{
    Name = "Chicken Adobo",
    Category = "Main Course",
    PrepTimeMinutes = 45
};

kitchen.AddMeal(meal);

Console.WriteLine();
Console.WriteLine(kitchen.GetKitchenInfo());

Console.WriteLine("\nMeals in Kitchen:");
foreach (var m in kitchen.GetMeals())
{
    Console.WriteLine($"- {m.Name} ({m.Category})");
}

Console.WriteLine("\n======================================");
Console.WriteLine("        PROGRAM FINISHED");
Console.WriteLine("======================================");