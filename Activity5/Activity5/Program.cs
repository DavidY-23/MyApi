using Newtonsoft.Json;

namespace Activity5
{
    class Joke
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("setup")]
        public string Setup { get; set; }

        [JsonProperty("punchline")]
        public string Punchline { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

    }

    public class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            await ProcessRepositories();
        }
        private static async Task ProcessRepositories()
        {

            while(true)
            {
                Console.WriteLine("Type joke for a random joke!");
                var readJoke = Console.ReadLine();
                if (string.IsNullOrEmpty(readJoke))
                {
                    break;
                }
                try
                {
                    var result = await client.GetAsync("https://official-joke-api.appspot.com/random_joke");
                    var resultRead = await result.Content.ReadAsStringAsync();
                    var joke = JsonConvert.DeserializeObject<Joke>(resultRead);

                    Console.WriteLine(joke.Setup);
                    Console.WriteLine(joke.Punchline);
                    Console.WriteLine("This joke was number: " + joke.Id + " and the type of joke is " + joke.Type);
                }
                catch (Exception)
                {
                    Console.Write("Error");
                }
            }
        }
    }

}