using Volo.Abp.Modularity;

namespace SeemsAdmin;

/* Inherit from this class for your domain layer tests. */
public abstract class SeemsAdminDomainTestBase<TStartupModule> : SeemsAdminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
