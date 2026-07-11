using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises
{
    public class GetMealById
    {
        public static async Task Run()
        {
            using HttpClient client = new HttpClient();

            string url = "https://www.themealdb.com/api/json/v1/1/lookup.php?i=52771";

            HttpResponseMessage response = await client.GetAsync(url);
            string body = await response.Content.ReadAsStringAsync();

            JsonDocument doc = JsonDocument.Parse(body);

            JsonElement meals = doc.RootElement.GetProperty("meals");

            Console.WriteLine("========== Exercise 3 ==========");

            if (response.IsSuccessStatusCode &&
                meals.ValueKind == JsonValueKind.Array)
            {
                string mealName = meals[0].GetProperty("strMeal").GetString()!;

                if (mealName == "Spicy Arrabiata Penne")
                {
                    Console.WriteLine("[PASS]");
                    Console.WriteLine($"Meal Name: {mealName}");
                }
                else
                {
                    Console.WriteLine("[FAIL]");
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