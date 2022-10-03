using System;
using System.Threading.Tasks
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }
        private static async Task ProcessRepositories()
        {
            while (true)
            try
            {
                Console.WriteLine("Enter Pokemon.");
                var pokemonName = console.ReadLine();

                if (string.IsNullOrEmpty(pokemonName))
                {
                    break;
                }

                var result = await client.GetAsync("https://pokeapi.co/api/v2/pokemon" + pokemonName.ToLower());
                var resultRead = await result.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                console.WriteLine("Error");
            }
        }

    }
}