using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNEmsResource.EntityFrameworkCore
{
    public class VNEmsResourceDbContextFactory : IDesignTimeDbContextFactory<VNEmsResourceDbContext>
    {
        public VNEmsResourceDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<VNEmsResourceDbContext>()
                .UseNpgsql(configuration.GetConnectionString("Default"));

            return new VNEmsResourceDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../VNEmsResource.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
