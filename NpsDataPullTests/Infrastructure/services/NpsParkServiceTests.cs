// NpsParkServiceTests.cs
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Moq;
using Moq.Protected;
using Newtonsoft.Json;
using NpsDataPull.Domain.Models;
using NpsDataPull.Infrastructure.Services;
using Xunit;

namespace NpsDataPullTests.Infrastructure.Services
{
    public class NpsParkServiceTests
    {
        [Fact]
        public async Task GetParksAsync_ReturnsParks()
        {
            // Arrange
            var mockConfiguration = new Mock<IConfiguration>();
            mockConfiguration.Setup(c => c["ApiSettings:BaseUrl"]).Returns("https://developer.nps.gov/api/v1");
            //mockConfiguration.SetupGet(c => c["ApiSettings:ApiKey"]).Returns("test-api-key");

            var mockHttpMessageHandler = new Mock<HttpMessageHandler>();
            mockHttpMessageHandler.Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(JsonConvert.SerializeObject(new NpsParksApi
                    {
                        Total = "1",
                        Parks =
                        [
                            new Park
                            {
                                FullName = "Test Park",
                                Description = "A beautiful park for testing."
                            }
                        ]
                    }))
                });

            var httpClient = new HttpClient(mockHttpMessageHandler.Object);
            var service = new NpsParkService(mockConfiguration.Object, httpClient);

            // Act
            var result = await service.GetParksAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal("1", result?.Total);
            Assert.Single(result?.Parks);
            Assert.Equal("Test Park", result?.Parks[0].FullName);
            Assert.Equal("A beautiful park for testing.", result?.Parks[0].Description);
        }
    }
}