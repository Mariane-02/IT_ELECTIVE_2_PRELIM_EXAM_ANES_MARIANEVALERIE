using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises
{
    public class FilterByIngredient
    {
        public static async Task Run()
        {
            using HttpClient client = new HttpClient();

            string url = "https://www.themealdb.com/api/json/v1/1/filter.php?i=chicken_breast";

            HttpResponseMessage response = await client.GetAsync(url);
            string body = await response.Content.ReadAsStringAsync();

            JsonDocument doc = JsonDocument.Parse(body);

            JsonElement meals = doc.RootElement.GetProperty("meals");

            Console.WriteLine("========== Exercise 5 ==========");

            if (response.IsSuccessStatusCode &&
                meals.ValueKind == JsonValueKind.Array &&
                meals.GetArrayLength() > 0)
            {
                Console.WriteLine("[PASS]");
                Console.WriteLine($"Total Meals Found: {meals.GetArrayLength()}");

                Console.WriteLine("\nMeals:");

                foreach (JsonElement meal in meals.EnumerateArray())
                {
                    Console.WriteLine("- " + meal.GetProperty("strMeal").GetString());
                }
            }
            else
            {
                Console.WriteLine("[FAIL]");
            }

            Console.WriteLine();
        }
    }
}