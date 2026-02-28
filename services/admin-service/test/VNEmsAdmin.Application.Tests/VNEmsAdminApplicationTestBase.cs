using Volo.Abp.Modularity;

namespace VNEmsAdmin;

public abstract class VNEmsAdminApplicationTestBase<TStartupModule> : VNEmsAdminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
