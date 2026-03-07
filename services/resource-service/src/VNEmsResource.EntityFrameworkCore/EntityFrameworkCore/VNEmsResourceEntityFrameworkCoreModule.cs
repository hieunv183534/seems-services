using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VNEmsResource.EntityFrameworkCore;

[DependsOn(
    typeof(VNEmsResourceDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class VNEmsResourceEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<VNEmsResourceDbContext>(options =>
        {
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
            options.AddDefaultRepositories(includeAllEntities: true);
        });

        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also VNEmsResourceMigrationsDbContextFactory for EF Core tooling. */
            options.UseNpgsql();
        });
    }
}
