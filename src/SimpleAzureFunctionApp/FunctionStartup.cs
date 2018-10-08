using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimpleAzureFunctionApp;
using SimpleAzureFunctionApp.Services;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: WebJobsStartup(typeof(FunctionStartup))]
namespace SimpleAzureFunctionApp
{
    class FunctionStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddSingleton<ICustomService, CustomService>();
        }
    }
}
