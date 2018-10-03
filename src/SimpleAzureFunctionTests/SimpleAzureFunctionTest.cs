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
            var req = new Mock<HttpRequest>();
            req.Setup(x => x.Body).Returns(new MemoryStream());

            var logger = new Mock<ILogger>();

            var res = SimpleAzureFunction.Run(req.Object, "Dave", logger.Object);

            var result = (OkObjectResult)res; 

            Assert.Equal(200, result.StatusCode);
            Assert.Equal("Dave", result.Value);
        }
    }
}
