using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAzureFunctionExtension.Services
{
    internal interface ISimpleService
    {
        Guid Id { get; }
    }
}
