// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Text.Json;

namespace GitHub_User_Activity
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var config = new ConfigurationBuilder()
            .AddUserSecrets<Program>()
            .Build();

            string apiKey = config["api_key"];

            while (true)
            {
                Console.WriteLine("---GitHub User Activity--");
                Console.WriteLine();
                Console.WriteLine("Enter desired user to fetch the activity from.");
                Console.Write("> ");
                string username = Console.ReadLine();

                GitHubEvent githubevent = new GitHubEvent();

                var client = new HttpClient();

                var url = new Uri("https://api.github.com");
                client.BaseAddress = url;

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github+json"));
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHub-User-Activity", "1.0"));

                var response = await client.GetAsync($"/users/{username}/events");

                var content = await response.Content.ReadAsStringAsync();

                //

                var github = JsonSerializer.Deserialize<List<GitHubEvent>>(content);

                GitHubUser githubUser = DuplicateHandler.UnionToOneUser(github);

                //

                Console.WriteLine();
                foreach (GitHubRepoActivity repo in githubUser.Repos)
                {
                    string message = MessageHandler.EventMessages(repo);
                    Console.WriteLine(message);
                    Console.WriteLine();
                }

                break;
            }
        }
    }
}
