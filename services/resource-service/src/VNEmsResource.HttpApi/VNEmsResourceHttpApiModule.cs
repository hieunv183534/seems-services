using Localization.Resources.AbpUi;
using VNEmsResource.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace VNEmsResource;

[DependsOn(
    typeof(VNEmsResourceApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class VNEmsResourceHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(VNEmsResourceHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<VNEmsResourceResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
