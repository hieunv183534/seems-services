using Volo.Abp.Modularity;

namespace SeemsAdmin;

[DependsOn(
    typeof(SeemsAdminDomainModule),
    typeof(SeemsAdminTestBaseModule)
)]
public class SeemsAdminDomainTestModule : AbpModule
{

}
