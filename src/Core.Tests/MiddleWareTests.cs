using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;
using Xunit;
using Fenris.Core;
using Microsoft.AspNetCore.Hosting;

namespace Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task ReturnsOkWithNormalRequest()
        {
            using var host = await new HostBuilder().ConfigureWebHost(webBuilder =>
            {
                webBuilder.UseTestServer()
                .Configure(app => app.UseFenris());
            }).StartAsync();

            var response = await host.GetTestServer().CreateClient().GetAsync("/");
        }
    }
}
