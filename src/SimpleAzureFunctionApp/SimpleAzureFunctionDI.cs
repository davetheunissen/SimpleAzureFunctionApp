
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SimpleAzureFunctionApp.Services;

namespace SimpleAzureFunctionApp
{
    public class SimpleAzureFunctionDI
    {
        private readonly ICustomService _customService;
        private readonly Guid _instanceId;

        public SimpleAzureFunctionDI(ICustomService customService)
        {
            _customService = customService;
            _instanceId = Guid.NewGuid();
        }

        [FunctionName("SimpleAzureFunctionDI")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            log.LogInformation($"Instance ID: {_instanceId}, Custom Service ID: {_customService.Id}");
            return new OkObjectResult(string.Empty);
        }
    }
}
