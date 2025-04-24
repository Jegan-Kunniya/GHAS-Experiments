using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace GhasExperiments.Tests.IntegrationTests
{
    public class SampleIntegrationTest
    {
        private readonly HttpClient _client;

        public SampleIntegrationTest()
        {
            var webAppFactory = new CustomWebApplicationFactory<Startup>();
            _client = webAppFactory.CreateClient();
        }

        [Test]
        public async Task Index_ReturnsSuccessStatusCode()
        {
            // Arrange
            var requestUri = "/";

            // Act
            var response = await _client.GetAsync(requestUri);

            // Assert
            response.EnsureSuccessStatusCode();
        }
    }
}