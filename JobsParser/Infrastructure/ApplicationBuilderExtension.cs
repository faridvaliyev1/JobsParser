using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JobsParser.Infrastructure
{
    public static class ApplicationBuilderExtension
    {
        public static void ApplyMigrations(this IApplicationBuilder applicationBuilder)
        {
            using var services = applicationBuilder.ApplicationServices.CreateScope();

            var DbContext = services.ServiceProvider.GetService<ApplicationDbContext>();

            DbContext.Database.Migrate();
        }
    }
}
