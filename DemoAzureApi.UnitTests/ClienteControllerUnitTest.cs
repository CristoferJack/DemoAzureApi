using FluentAssertions;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace DemoAzureApi.UnitTests
{
    public class ClienteControllerUnitTest
    {
        [Fact]
        public async Task GetClientesTest()
        {
            using (var client = new TestProvider().Client)
            {
                var response = await client.GetAsync("/api/Cliente");

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }
    }
}
