using Volo.Abp.Modularity;

namespace VNEmsResource;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class VNEmsResourceApplicationTestBase<TStartupModule> : VNEmsResourceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
