using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using EZCom.Application;
using EZCom.Infrastructure;
using Microsoft.Extensions.Configuration;
using Infrastructure.Persistence.Data;

namespace EZCom.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<ApplicationDbContext>() 
                .Build();
            var services = new ServiceCollection();
            services.AddApplication();
            services.AddInfrastructure(configuration);

           
            services.AddTransient<Form1>();

            using var provider = services.BuildServiceProvider();
            var mainForm = provider.GetRequiredService<Form1>();

            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}
