using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using VNEms.Hosting.Shared;

namespace VNEmsAdmin;

public class Program
{
    public async static Task<int> Main(string[] args)
    {
        VNEmsLogging.Initialize();

        try
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            Log.Information("Starting VNEmsAdmin.AuthServer.");
            var builder = WebApplication.CreateBuilder(args);

            builder.AddServiceDefaults();
            builder.AddSharedEndpoints();

            builder.Host.AddAppSettingsSecretsJson()
                .UseAutofac()
                .UseSerilog();
            await builder.AddApplicationAsync<VNEmsAuthServerModule>();
            var app = builder.Build();
            await app.InitializeApplicationAsync();
            await app.RunAsync();
            return 0;
        }
        catch (Exception ex)
        {
            if (ex is HostAbortedException)
            {
                throw;
            }

            Log.Fatal(ex, "VNEmsAdmin.AuthServer terminated unexpectedly!");
            return 1;
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}
