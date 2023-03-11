using HumanResourcesModule.Entity.DataAccess;
using HumanResourcesModule.Repository.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HumanResourcesModule.Repository;

public static class DependencyRegister
{
    public static void AddRepository(this IServiceCollection services)
    {

        IConfiguration configuration = services.BuildServiceProvider().GetService<IConfiguration>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddSingleton<HumanResourcesDataContext>();
        services.AddSingleton<ICityRepository, CityRepository>();

    }
}