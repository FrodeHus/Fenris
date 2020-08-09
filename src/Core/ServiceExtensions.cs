using Microsoft.AspNetCore.Builder;

namespace Fenris.Core
{
    public static class ServiceExtensions
    {
        public static IApplicationBuilder UseFenris(this IApplicationBuilder app)
        {
            return app;
        }
    }
}