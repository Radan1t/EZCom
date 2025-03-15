using Infrastructure.Persistence.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using EZCom.Application.Interfaces;
using Infrastructure.Persistence.Repositories;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Application.Interfaces.Services;
using Infrastructure.Services;
using Application.Interfaces;


namespace EZCom.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<ICodeSenderService, CodeSenderService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ICompanyService, CompanyService>();

            return services;
        }
    }
}
