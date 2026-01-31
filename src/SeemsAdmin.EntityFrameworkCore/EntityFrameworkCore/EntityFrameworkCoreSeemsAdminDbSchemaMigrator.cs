using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SeemsAdmin.Data;
using Volo.Abp.DependencyInjection;

namespace SeemsAdmin.EntityFrameworkCore;

public class EntityFrameworkCoreSeemsAdminDbSchemaMigrator
    : ISeemsAdminDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSeemsAdminDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the SeemsAdminDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SeemsAdminDbContext>()
            .Database
            .MigrateAsync();
    }
}
