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
using EZCom.Forms.Admin;
using EZCom.Forms.Chat;
using EZCom.Forms.Meet;

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
            services.AddTransient<MainNoComp>();
            services.AddTransient<CreateCompany>();
            services.AddTransient<MainForm>();
            services.AddTransient<Adminform>();
            services.AddTransient<Chatform>();
            services.AddTransient<NewChat>();
            services.AddTransient<Meetform>();

            ServiceProvider = services.BuildServiceProvider();  

            var mainForm = ServiceProvider.GetRequiredService<Login>();
            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}
