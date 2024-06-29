﻿namespace CodePilot.Services
{
    public class QuestionsFromApi
    {
        static async Task Main(string[] args)
        {
            // Replace with your actual endpoint URL
            string apiUrl = "https://codeforces.com/api/contest.list?gym=false";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode(); // Ensure success before reading response

                    string responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody); // Output the JSON response
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
