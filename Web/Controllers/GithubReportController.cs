using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text.Json;
using Web.Entities.GithubReport;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GithubReportController : ControllerBase
    {
        [HttpGet]
        public List<string> GetPR([FromQuery] string baseAddress = "https://api.github.com",
            [FromQuery] string repoOwner = "efalabrini",
            [FromQuery] string repo = "Practica1Prog3TUP",
            [FromQuery] string titleContains = "")
        {

            HttpClient httpClient = new()
            {
                BaseAddress = new Uri(baseAddress),
            };

            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
            httpClient.DefaultRequestHeaders.Add("X-GitHub-Api-Version", "2022-11-28");
            httpClient.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Practica1Prog3TUP", "1.0.0"));

            int per_page = 1000;

            string stringQuery = $"per_page={per_page}&state=all";
            string queryRoute = $"repos/{repoOwner}/{repo}/pulls";
            string query = $"{queryRoute}?{stringQuery}";

            //////////////Query with pagination
            string linksHeader = "";
            string nextQuery = "";
            List<PullRequest>? listAux;
            List<PullRequest>? listPR = [];
            do
            {
                using HttpResponseMessage response = httpClient.GetAsync(query).Result;

                response.EnsureSuccessStatusCode();

                var jsonResponse = response.Content.ReadAsStringAsync().Result;


                linksHeader = "";
                nextQuery = "";
                query = "";
                IEnumerable<string>? values;
                if (response.Headers.TryGetValues("Link", out values))
                {
                    linksHeader = values.First();
                }
                if (linksHeader.Contains("rel=\"next\""))
                {
                    var listAux2 = linksHeader.Split(",");
                    foreach (string lhaux in listAux2)
                    {
                        if (lhaux.Contains("rel=\"next\""))
                        {
                            nextQuery = lhaux.Split(";")[0];
                            nextQuery = nextQuery.Trim();
                            nextQuery = nextQuery.Substring(1, nextQuery.Length - 2);
                            query = nextQuery;
                        }
                    }
                }

                listAux = JsonSerializer.Deserialize<List<PullRequest>>(jsonResponse);
                if (listAux == null) throw new Exception("empty jason");

                foreach (PullRequest pr in listAux)
                {
                    listPR.Add(pr);
                }

            } while (query != "");
            /////////////

            //To do
            //Write a LINQ query in Query syntax to return
            //PR in state "open" or merged, and filter by PR.title cointaining {titleContains} (IgnoreCase).
            var queryToGroupByUser = "";

            var listGroupedByUser = (queryToGroupByUser).ToList();

            //To do
            //Write a LINQ query in Query syntax to return from listGroupedByUser:
            //user.login count(pr)
            //order by count(pr) descending
            var reportQuery = "";

            //Output example
            //[
            //  "pedrogasparini 16",
            //  "nicocarc04 15",
            //  "facundolgomez 15",
            //  "JuaniTorti 14",
            //  "lucianofer02 13"
            //  ...
            //]
            return reportQuery.ToList();

        }
    }
}
