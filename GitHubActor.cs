using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GitHub_User_Activity
{
    public class GitHubActor
    {
        [JsonPropertyName("id")]
        public long ID { get; set; }

    }
}
