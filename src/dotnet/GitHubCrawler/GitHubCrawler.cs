using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace GitHubCrawler
{
    public class GitHubCrawler
    {
        private readonly ILogger<GitHubCrawler> _logger;

        public GitHubCrawler(ILogger<GitHubCrawler> logger)
        {
            _logger = logger;
        }

        [Function("GitHubCrawler")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
