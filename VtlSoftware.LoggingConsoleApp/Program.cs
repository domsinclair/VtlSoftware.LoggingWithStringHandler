using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using VtlSoftware.Logging.Net6;

namespace VtlSoftware.LoggingConsoleApp
{
    [NoLog]
    internal class Program
    {
        #region Private Methods

        static void BuildConfig(IConfigurationBuilder builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile(
                $"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production"}.json",
                optional: true)
            .AddEnvironmentVariables();
        }

        static void Main(string[] args)
        {
            //---------------------------------------------------------------------------
            // Use the code below to run as a basic Microsoft extensions logger 
            // logging to the console.  You will get text output that is perfectly readable.
            // Remember to comment out the serilog code.
            // ---------------------------------------------------------------------------

            var serviceProvider = new ServiceCollection()
            .AddLogging(builder => builder.AddConsole().SetMinimumLevel(LogLevel.Trace))
            .AddSingleton<Calculator>()
            .BuildServiceProvider();

            var calculator = serviceProvider.GetService<Calculator>()!;

            try
            {
                calculator.FirstNumber = 67;
                calculator.Add(1, 1);
                calculator.DivideInt(5, 0);
            } catch
            {
            }

            //To use serilog uncomment what comes below
            // Remembering to comment out what is above.

            //var builder = new ConfigurationBuilder();
            //BuildConfig(builder);

            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(builder.Build())
            //    .CreateLogger();

            //var host = Host.CreateDefaultBuilder()
            //    .ConfigureServices(
            //        services =>
            //        {
            //            services.AddTransient<Calculator>();
            //        })
            //    .UseSerilog()
            //    .Build();

            //Log.Logger.Information("Application Starting");

            ////  not yet perfect  calculator is being called but internal logging is not.
            //var svc = ActivatorUtilities.CreateInstance<Calculator>(host.Services);
            //svc.Add(1, 3);
            //svc.Divide(5, 0);
            //svc.DivideInt(5, 0);

            //Log.Logger.Information("Application Closing");
            //Log.CloseAndFlush();
        }

        #endregion
    }
}