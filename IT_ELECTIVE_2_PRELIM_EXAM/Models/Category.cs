namespace IT_ELECTIVE_2_PRELIM_OOP.Models
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Category()
        {
            Name = Description = "";
        }

        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
