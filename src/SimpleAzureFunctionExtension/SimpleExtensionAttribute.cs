using Microsoft.Azure.WebJobs.Description;
using System;
using System.Text;

namespace SimpleAzureFunctionExtension
{
    [Binding]
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public class SimpleExtensionAttribute : Attribute
    {
        public string Name { get; set; }
    }
}
