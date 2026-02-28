using Volo.Abp.Modularity;

namespace VNEmsAdmin;

[DependsOn(
    typeof(VNEmsAdminApplicationModule),
    typeof(VNEmsAdminDomainTestModule)
)]
public class VNEmsAdminApplicationTestModule : AbpModule
{

}
