using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Application.Common.DTO;
using Application.Common.Validators;
using System.Reflection;

namespace EZCom.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IValidator<UserDTO>, RegistrationValidator>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
