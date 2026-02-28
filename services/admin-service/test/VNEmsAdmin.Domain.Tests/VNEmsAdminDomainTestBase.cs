using Volo.Abp.Modularity;

namespace VNEmsAdmin;

/* Inherit from this class for your domain layer tests. */
public abstract class VNEmsAdminDomainTestBase<TStartupModule> : VNEmsAdminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
