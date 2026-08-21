using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GitHub_User_Activity
{
    public class GitHubEvent
    {
        /// <summary>
        /// WatchEvent - Starred repo
        /// PushEvent - Pushed commit
        /// IssuesEvent - Issued an issue
        /// </summary>

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("actor")]
        public GitHubActor Actor { get; set; }

        [JsonPropertyName("repo")]
        public GitHubRepoActivity Repo { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime Date { get; set; }


    }
}
