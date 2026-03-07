using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace VNEmsResource;

[DependsOn(
    typeof(VNEmsResourceDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class VNEmsResourceApplicationContractsModule : AbpModule
{

}
