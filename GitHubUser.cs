using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_User_Activity
{
    public class GitHubUser
    {
        public long ID { get; set;}
        public List<GitHubRepoActivity> Repos { get; set; }

    }
}
