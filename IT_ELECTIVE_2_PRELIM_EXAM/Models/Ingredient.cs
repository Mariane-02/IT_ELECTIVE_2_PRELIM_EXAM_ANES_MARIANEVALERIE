using System;

namespace IT_ELECTIVE_2_PRELIM_OOP.Models
{
    public class Ingredient
    {
        private string name = string.Empty;
        private int quantity;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Quantity));
                quantity = value;
            }
        }

        public Ingredient()
        {
            Name = "Unknown";
        }

        public Ingredient(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}