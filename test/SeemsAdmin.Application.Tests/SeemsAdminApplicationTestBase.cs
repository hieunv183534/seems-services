using Volo.Abp.Modularity;

namespace SeemsAdmin;

public abstract class SeemsAdminApplicationTestBase<TStartupModule> : SeemsAdminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
