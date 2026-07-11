using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises
{
    public class GetCategories
    {
        public static async Task Run()
        {
            using HttpClient client = new HttpClient();

            string url = "https://www.themealdb.com/api/json/v1/1/categories.php";

            HttpResponseMessage response = await client.GetAsync(url);
            string body = await response.Content.ReadAsStringAsync();

            JsonDocument doc = JsonDocument.Parse(body);

            JsonElement categories = doc.RootElement.GetProperty("categories");

            Console.WriteLine("========== Exercise 4 ==========");

            if (response.IsSuccessStatusCode &&
                categories.ValueKind == JsonValueKind.Array &&
                categories.GetArrayLength() > 0)
            {
                Console.WriteLine("[PASS]");
                Console.WriteLine($"Total Categories: {categories.GetArrayLength()}");

                Console.WriteLine("\nCategories:");

                foreach (JsonElement category in categories.EnumerateArray())
                {
                    Console.WriteLine("- " + category.GetProperty("strCategory").GetString());
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