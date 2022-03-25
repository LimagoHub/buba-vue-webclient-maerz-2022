using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebClientDemo
{
    class Program
    {

        private static readonly HttpClient client = new HttpClient();
        
        static async Task Main(string[] args)
        {
            Console.WriteLine("--------------------Start---------------");
            await ProcessRepositories();
            Console.WriteLine("--------------------Ende---------------");
        }

        private static async Task ProcessRepositories()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            Console.WriteLine("Anfang");
            
            var streamTask = client.GetStreamAsync("http://localhost:5000/weatherforecast");
            Console.WriteLine("Vorher");
            var weatherforecasts = await JsonSerializer.DeserializeAsync<List<WeatherForecast>>(await streamTask);
            foreach (var wf in weatherforecasts)
            {
                Console.WriteLine(wf);
            }
        }
    }
}
