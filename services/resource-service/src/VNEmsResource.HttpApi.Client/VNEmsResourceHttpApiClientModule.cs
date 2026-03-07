using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace VNEmsResource;

[DependsOn(
    typeof(VNEmsResourceApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class VNEmsResourceHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(VNEmsResourceApplicationContractsModule).Assembly,
            VNEmsResourceRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<VNEmsResourceHttpApiClientModule>();
        });

    }
}
