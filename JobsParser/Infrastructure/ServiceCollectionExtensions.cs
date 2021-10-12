using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JobsParser.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApiControllers(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    options.SerializerSettings.Converters.Add(new IsoDateTimeConverter
                    {
                        DateTimeFormat = "dd.MM.yyyy HH:mm"
                    });
                });
        }
    }
}
