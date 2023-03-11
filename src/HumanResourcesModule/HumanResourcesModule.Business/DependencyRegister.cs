using HumanResourcesModule.Business.Services.City;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HumanResourcesModule.Business;

public static class DependencyRegister
{
    public static void AddServices(this IServiceCollection services)
    {

        IConfiguration configuration = services.BuildServiceProvider().GetService<IConfiguration>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddSingleton<ICityService, CityService>();

    }
}