using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using VNEmsResource.Data;
using Volo.Abp.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace VNEmsResource.EntityFrameworkCore
{
    public class EntityFrameworkCoreVNEmsResourceDbSchemaMigrator : IVNEmsResourceDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreVNEmsResourceDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolve the VNEmsResourceDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<VNEmsResourceDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
