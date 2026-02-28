using VNEmsAdmin.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace VNEmsAdmin.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(VNEmsAdminEntityFrameworkCoreModule),
    typeof(VNEmsAdminApplicationContractsModule)
    )]
public class VNEmsAdminDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "VNEmsAdmin:"; });
    }
}
