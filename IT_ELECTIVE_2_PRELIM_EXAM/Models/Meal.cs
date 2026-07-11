namespace IT_ELECTIVE_2_PRELIM_OOP.Models
{
    public class Meal
    {
        private string name = string.Empty;
        private string category = string.Empty;
        private int prepTimeMinutes;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Category
        {
            get => category;
            set => category = value;
        }

        public int PrepTimeMinutes
        {
            get => prepTimeMinutes;
            set => prepTimeMinutes = value;
        }
    }
}