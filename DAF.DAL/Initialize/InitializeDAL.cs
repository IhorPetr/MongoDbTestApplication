using Microsoft.Extensions.Configuration;
using DAF.DAL.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace DAF.DAL.Initialize
{
    public static class InitializeDAL
    {
        public static void ConfigureDependencyInjectionDAL(this IServiceCollection services, IConfiguration Configuration)
        {
            services.Configure<DatabaseSetting>(options =>
            {
                options.ConnectionString
                    = Configuration.GetSection("MongoConnection:ConnectionString").Value;
                options.Database
                    = Configuration.GetSection("MongoConnection:Database").Value;
            });
        }
    }
}
