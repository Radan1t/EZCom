using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using EZCom.Application;
using EZCom.Infrastructure;

namespace EZCom.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            services.AddApplication();
            services.AddInfrastructure();

           
            services.AddTransient<Form1>();

            using var provider = services.BuildServiceProvider();
            var mainForm = provider.GetRequiredService<Form1>();

            System.Windows.Forms.Application.Run(mainForm);
        }
    }
}
