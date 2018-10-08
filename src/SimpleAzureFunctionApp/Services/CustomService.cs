using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAzureFunctionApp.Services
{
    public class CustomService : ICustomService
    {
        public CustomService()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
