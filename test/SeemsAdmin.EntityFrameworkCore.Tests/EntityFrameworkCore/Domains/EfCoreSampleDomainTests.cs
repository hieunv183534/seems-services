using SeemsAdmin.Samples;
using Xunit;

namespace SeemsAdmin.EntityFrameworkCore.Domains;

[Collection(SeemsAdminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SeemsAdminEntityFrameworkCoreTestModule>
{

}
