using VNEmsResource;
using VNEmsResource.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace VNEmsResource.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(VNEmsResourceEntityFrameworkCoreModule),
    typeof(VNEmsResourceApplicationContractsModule)
    )]
public class VNEmsResourceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "VNEmsResource:"; });
    }
}
