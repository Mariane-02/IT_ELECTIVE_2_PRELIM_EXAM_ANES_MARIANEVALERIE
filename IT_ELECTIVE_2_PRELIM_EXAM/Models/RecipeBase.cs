namespace IT_ELECTIVE_2_PRELIM_OOP.Models
{
    public class RecipeBase
    {
        public string Title { get; set; } = "";
        public int PrepTimeMinutes { get; set; }
        public string Difficulty { get; set; } = "";

        public RecipeBase() { }

        public RecipeBase(string title, int prepTimeMinutes, string difficulty)
        {
            Title = title;
            PrepTimeMinutes = prepTimeMinutes;
            Difficulty = difficulty;
        }

        public virtual string GetRecipeInfo() =>
            $"Title: {Title}, Prep Time: {PrepTimeMinutes} mins, Difficulty: {Difficulty}";
    }
}