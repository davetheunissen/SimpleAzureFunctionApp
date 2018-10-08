using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAzureFunctionApp.Services
{
    public interface ICustomService
    {
        Guid Id { get; }
    }
}
