using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_User_Activity
{
    public static class MessageHandler
    {
        public static string EventMessages(GitHubRepoActivity repoActivity)
        {
            string message = "Error: did not recognize the json value returned from github.";
            string repoName = repoActivity.Name;
            DateTime repoDate = repoActivity.Date;

            switch (repoActivity.Type)
            {
                case "PushEvent":
                    message = $"Pushed a commit in {repoName} ({repoDate})";
                    break;
                case "CommitCommentEvent":
                    message = $"Created a commit comment in {repoName} ({repoDate})";
                    break;
                case "CreateEvent":
                    message = $"Created a git branch or tag in {repoName} ({repoDate})";
                    break;
                case "DeleteEvent":
                    message = $"Deleted a git branch or tag in {repoName} ({repoDate})";
                    break;
                case "DiscussionEvent":
                    message = $"Created a discussion in {repoName} ({repoDate})";
                    break;
                case "ForkEvent":
                    message = $"Forked a repository in {repoName} ({repoDate})";
                    break;
                case "GollumEvent":
                    message = $"Updated or created a wiki page in {repoName} ({repoDate})";
                    break;
                case "IssueCommentEvent":
                    message = $"Performed an action to an issue or pull request in {repoName} ({repoDate})";
                    break;
                case "IssuesEvent":
                    message = $"Opened, closed, reopened, assigned, unassigned, labeled, or unlabeled an issue in {repoName} ({repoDate})";
                    break;
                case "MemberEvent":
                    message = $"Performed an action related to repository collaborators in {repoName} ({repoDate})";
                    break;
                case "PublicEvent":
                    message = $"Made {repoName} public ({repoDate})";
                    break;
                case "PullRequestEvent":
                    message = $"Performed an action related to pull requests in {repoName} ({repoDate})";
                    break;
                case "ReleaseEvent":
                    message = $"Performed an action related to a release in {repoName} ({repoDate})";
                    break;
                case "WatchEvent":
                    message = $"Starred {repoName} ({repoDate})";
                    break;
            }

            return message;


        }
    }
}
