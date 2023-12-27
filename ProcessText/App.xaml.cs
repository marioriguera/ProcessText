using System;
using System.Windows;
using Microsoft.Extensions.Hosting;
using NLog;
using ProcessText.Config;
using ProcessText.Core.Dependencies;

namespace ProcessText
{
    /// <summary>
    /// Interaction logic for App.xaml.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Logger field for generate logs.
        /// </summary>
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            ConfigurationService.Current.Host = Host.CreateDefaultBuilder().AddCoreDependencies().Build();
        }

        /// <inheritdoc/>
        protected override void OnStartup(StartupEventArgs e)
        {
            try
            {
                base.OnStartup(e);

                NLogConfigurator.Initialize();
                NLogConfigurator.AddDebugger();
                NLogConfigurator.ApplyConfigurationToLogs();

                MainWindow = new MainWindow();
                MainWindow.Show();

                _logger.Info($"Application started.");
            }
            catch (Exception ex)
            {
                _logger.Fatal(ex, $"An unhandled exception has occurred at the time of starting the application.");
            }
        }
    }
}
