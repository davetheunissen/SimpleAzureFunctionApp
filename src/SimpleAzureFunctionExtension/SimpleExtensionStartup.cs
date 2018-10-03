using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SimpleAzureFunctionExtension;
using SimpleAzureFunctionExtension.Config;
using System;

[assembly: WebJobsStartup(typeof(SimpleExtensionStartup))]
namespace SimpleAzureFunctionExtension
{
    public class SimpleExtensionStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddSimpleExtension();
        }
    }
}
