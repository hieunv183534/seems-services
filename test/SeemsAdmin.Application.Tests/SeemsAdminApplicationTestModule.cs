using Volo.Abp.Modularity;

namespace SeemsAdmin;

[DependsOn(
    typeof(SeemsAdminApplicationModule),
    typeof(SeemsAdminDomainTestModule)
)]
public class SeemsAdminApplicationTestModule : AbpModule
{

}
