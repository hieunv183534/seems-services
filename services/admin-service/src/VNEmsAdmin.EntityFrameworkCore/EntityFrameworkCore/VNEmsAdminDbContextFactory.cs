using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using VNEms.Shared.Constants;

namespace VNEmsAdmin.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class VNEmsAdminDbContextFactory : IDesignTimeDbContextFactory<VNEmsAdminDbContext>
{
    public VNEmsAdminDbContext CreateDbContext(string[] args)
    {
        VNEmsAdminEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<VNEmsAdminDbContext>()
            .UseNpgsql(configuration.GetConnectionString(VNEmsNames.VNEmsAdminDb));

        return new VNEmsAdminDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../VNEmsAdmin.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
