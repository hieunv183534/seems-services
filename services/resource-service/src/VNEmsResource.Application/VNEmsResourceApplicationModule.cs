using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace VNEmsResource;

[DependsOn(
    typeof(VNEmsResourceDomainModule),
    typeof(VNEmsResourceApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class VNEmsResourceApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<VNEmsResourceApplicationModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<VNEmsResourceApplicationModule>(validate: true);
        });
    }
}
