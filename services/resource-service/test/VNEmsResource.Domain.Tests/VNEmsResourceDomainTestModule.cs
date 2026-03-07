using Volo.Abp.Modularity;

namespace VNEmsResource;

[DependsOn(
    typeof(VNEmsResourceDomainModule),
    typeof(VNEmsResourceTestBaseModule)
)]
public class VNEmsResourceDomainTestModule : AbpModule
{

}
