using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAzureFunctionExtension.Services
{
    internal sealed class SimpleService : ISimpleService
    {
        public string GetHelloWorld(string name)
        {
            return $"{name} says Hello World!";
        }
    }
}
