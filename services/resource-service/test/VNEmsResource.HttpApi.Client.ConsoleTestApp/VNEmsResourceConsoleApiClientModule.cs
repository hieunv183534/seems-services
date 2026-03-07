using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace VNEmsResource;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(VNEmsResourceHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class VNEmsResourceConsoleApiClientModule : AbpModule
{

}
