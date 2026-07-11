using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises
{
    public class SearchMealByName
    {
        public static async Task Run()
        {
            using HttpClient client = new HttpClient();

            string url = "https://www.themealdb.com/api/json/v1/1/search.php?s=Arrabiata";

            HttpResponseMessage response = await client.GetAsync(url);
            string body = await response.Content.ReadAsStringAsync();

            JsonDocument doc = JsonDocument.Parse(body);

            JsonElement meals = doc.RootElement.GetProperty("meals");

            Console.WriteLine("========== Exercise 2 ==========");

            if (response.IsSuccessStatusCode &&
                meals.ValueKind == JsonValueKind.Array &&
                meals.GetArrayLength() > 0)
            {
                Console.WriteLine("[PASS] Meal found.");

                string mealName = meals[0].GetProperty("strMeal").GetString()!;

                Console.WriteLine($"Meal Name: {mealName}");
            }
            else
            {
                Console.WriteLine("[FAIL]");
            }

            Console.WriteLine();
        }
    }
}