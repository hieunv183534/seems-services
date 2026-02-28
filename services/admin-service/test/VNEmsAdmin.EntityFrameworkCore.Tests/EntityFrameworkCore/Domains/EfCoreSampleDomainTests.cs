using VNEmsAdmin.Samples;
using Xunit;

namespace VNEmsAdmin.EntityFrameworkCore.Domains;

[Collection(VNEmsAdminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<VNEmsAdminEntityFrameworkCoreTestModule>
{

}
