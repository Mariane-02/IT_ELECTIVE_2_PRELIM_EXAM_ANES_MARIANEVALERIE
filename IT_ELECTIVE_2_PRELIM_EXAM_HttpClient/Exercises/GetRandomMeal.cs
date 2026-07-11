using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises
{
    public class GetRandomMeal
    {
        public static async Task Run()
        {
            using HttpClient client = new HttpClient();

            string url = "https://www.themealdb.com/api/json/v1/1/random.php";

            HttpResponseMessage response = await client.GetAsync(url);
            string body = await response.Content.ReadAsStringAsync();

            Console.WriteLine("========== Exercise 1 ==========");
            Console.WriteLine($"Status Code: {(int)response.StatusCode}");

            if (response.IsSuccessStatusCode && !string.IsNullOrWhiteSpace(body))
            {
                Console.WriteLine("[PASS] Successfully retrieved a random meal.");
            }
            else
            {
                Console.WriteLine("[FAIL]");
            }

            Console.WriteLine();
        }
    }
}