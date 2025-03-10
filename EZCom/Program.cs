using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using EZCom.Application;
using EZCom.Infrastructure;
using Microsoft.Extensions.Configuration;
using Infrastructure.Persistence.Data;
using FluentValidation;
using Application.Common.Validators;
using EZCom.Forms;
using EZCom.Forms.Main;

namespace EZCom.UI
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } 

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<ApplicationDbContext>()
                .Build();

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(configuration);
            services.AddApplication();
            services.AddInfrastructure(configuration);
            services.AddValidatorsFromAssemblyContaining<RegistrationValidator>();
            services.AddTransient<Login>();
            services.AddTransient<Registration>();
            services.AddTransient<RegistrationCode>();
            services.AddTransient<Main>();
            services.AddTransient<CreateCompany>();

            ServiceProvider = services.BuildServiceProvider();  

            var mainForm = ServiceProvider.GetRequiredService<Login>();
            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}
