using SeemsAdmin.Samples;
using Xunit;

namespace SeemsAdmin.EntityFrameworkCore.Applications;

[Collection(SeemsAdminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SeemsAdminEntityFrameworkCoreTestModule>
{

}
