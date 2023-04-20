using BNI_POC.API.Provider;

namespace BNI_POC
{
    public static class ServiceExtentions
    {
        public static void ConfigureAddScope(this IServiceCollection services)
        {
            services.AddScoped<ITrainingLogProvider, TrainingLogProvider>();
        }
    }
}
