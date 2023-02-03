using System;
using UserCreatorUI.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserOneLibrary.Factory;
using Models;
using UserOneLibrary.Adapter;

namespace UserCreatorUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {

                    services.AddTransient<IRepositoryFactory<UserTableModel>, RepositoryFactory<UserTableModel>>();
                    services.AddTransient<IRepositoryFactory<UserFieldModel>, RepositoryFactory<UserFieldModel>>();
                    services.AddTransient<IRepositoryFactory<UserObjectModel>, RepositoryFactory<UserObjectModel>>();

                    services.AddTransient<IServiceFactory<UserTableModel>, ServiceFactory<UserTableModel>>();
                    services.AddTransient<IServiceFactory<UserFieldModel>, ServiceFactory<UserFieldModel>>();
                    services.AddTransient<IServiceFactory<UserObjectModel>, ServiceFactory<UserObjectModel>>();

                    services.AddTransient<IAdapterFactory<IBOAdapter>, BOAdapterFactory>();

                    services.AddTransient<MainForm>();
                });
        }
    }
}