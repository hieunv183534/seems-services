using Volo.Abp.Modularity;

namespace VNEmsAdmin;

[DependsOn(
    typeof(VNEmsAdminDomainModule),
    typeof(VNEmsAdminTestBaseModule)
)]
public class VNEmsAdminDomainTestModule : AbpModule
{

}
