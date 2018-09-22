using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Moq;
using SimpleAzureFunctionApp;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace SimpleAzureFunctionTests
{
    public class SimpleAzureFunctionTest
    {
        [Fact]
        public void SimpleAzureFunction_Should_Return_Name()
        {
            var logger = new Mock<ILogger>();

            var query = new Dictionary<string, StringValues>();
            query.TryAdd("name", "dave");

            var req = new Mock<HttpRequest>();
            req.Setup(x => x.Query).Returns(new QueryCollection(query));
            req.Setup(x => x.Body).Returns(new MemoryStream());

            var res = SimpleAzureFunction.Run(req.Object, logger.Object);

            var result = (OkObjectResult)res; 

            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Hello, dave", result.Value);
        }
    }
}
