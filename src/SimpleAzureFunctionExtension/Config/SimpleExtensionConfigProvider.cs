using Microsoft.Azure.WebJobs.Host.Config;
using SimpleAzureFunctionExtension.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAzureFunctionExtension.Config
{
    class SimpleExtensionConfigProvider : IExtensionConfigProvider
    {
        private readonly ISimpleService _simpleService;

        public SimpleExtensionConfigProvider(ISimpleService simpleService)
        {
            _simpleService = simpleService;
        }

        /// <inheritdoc />
        public void Initialize(ExtensionConfigContext context)
        {
            if (context == null)
                throw new ArgumentNullException("ExtensionConfigContext");

            var inputRule = context.AddBindingRule<SimpleExtensionAttribute>();
            inputRule.BindToInput(BuildItemFromAttribute);
        }

        private string BuildItemFromAttribute(SimpleExtensionAttribute attribute)
        {
            return _simpleService.GetHelloWorld(attribute.Name);
        }
    }
}
