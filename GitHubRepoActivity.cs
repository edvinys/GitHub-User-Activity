using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GitHub_User_Activity
{
    public class GitHubRepoActivity
    {
        public GitHubRepoActivity(string name, string type, DateTime date)
        {
            Name = name;
            Type = type;
            Date = date;
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime Date { get; set; }
    }
}
