using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace SeemsAdmin.Data;

/* This is used if database provider does't define
 * ISeemsAdminDbSchemaMigrator implementation.
 */
public class NullSeemsAdminDbSchemaMigrator : ISeemsAdminDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
