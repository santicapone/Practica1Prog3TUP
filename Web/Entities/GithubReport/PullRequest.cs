namespace Web.Entities.GithubReport
{
    public record PullRequest(string url, User user, string state, string title, string merged_at)
    {

    }


}
