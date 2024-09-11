using CQRSPOC.APPLICATION.Manager.Concrete;
using CQRSPOC.APPLICATION.Manager.Contract;

namespace CQRSPOC.API;

public static class ServiceDependencies
{

    public static WebApplicationBuilder ConfigureService(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUserManager, UserManager>();
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));
        return builder;
    }

    public static WebApplication ConfigurePipeline(this WebApplication app) 
    { 
        return app; 
    }
}
