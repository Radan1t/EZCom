using Microsoft.Extensions.DependencyInjection;

namespace EZCom.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Додай тут реєстрацію сервісів для рівня Application
            return services;
        }
    }
}
