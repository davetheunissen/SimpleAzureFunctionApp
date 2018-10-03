using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.DependencyInjection;
using SimpleAzureFunctionExtension.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleAzureFunctionExtension.Config
{
    /// <summary>
    /// Extension methods for SimpleExtension integration.
    /// </summary>
    public static class WebJobsBuilderExtensions
    {
        /// <summary>
        /// Adds the SimpleExtension extension to the provided <see cref="IWebJobsBuilder"/>.
        /// </summary>
        /// <param name="builder">The <see cref="IWebJobsBuilder"/> to configure.</param>
        public static IWebJobsBuilder AddSimpleExtension(this IWebJobsBuilder builder)
        {
            // null check
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            // register custom extension config
            builder.AddExtension<SimpleExtensionConfigProvider>();
            // configure dependancy resolution
            builder.Services.AddSingleton<ISimpleService, SimpleService>();

            return builder;
        }
    }
}
