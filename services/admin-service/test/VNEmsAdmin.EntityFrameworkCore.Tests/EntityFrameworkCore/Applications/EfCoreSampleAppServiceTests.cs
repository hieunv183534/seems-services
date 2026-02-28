using VNEmsAdmin.Samples;
using Xunit;

namespace VNEmsAdmin.EntityFrameworkCore.Applications;

[Collection(VNEmsAdminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<VNEmsAdminEntityFrameworkCoreTestModule>
{

}
