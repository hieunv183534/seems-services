using Volo.Abp.Modularity;

namespace VNEmsResource;

[DependsOn(
    typeof(VNEmsResourceApplicationModule),
    typeof(VNEmsResourceDomainTestModule)
    )]
public class VNEmsResourceApplicationTestModule : AbpModule
{

}
