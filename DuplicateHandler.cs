using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_User_Activity
{
    public static class DuplicateHandler
    {
        public static GitHubUser UnionToOneUser(List<GitHubEvent> gitHubEvents)
        {
            if (gitHubEvents.Count == 0)
            {
                return null;
            }

            GitHubUser user = new GitHubUser();
            user.ID = gitHubEvents[0].Actor.ID; // only one user per call
            user.Repos = new List<GitHubRepoActivity>();

            for (int i = 0; i < gitHubEvents.Count; i++)
            {
                GitHubEvent git = gitHubEvents[i];

                var copy = new GitHubRepoActivity
                    (git.Repo.Name, git.Type, git.Date);
                user.Repos.Add(copy);
            }

            return user;
        }
    }
}
