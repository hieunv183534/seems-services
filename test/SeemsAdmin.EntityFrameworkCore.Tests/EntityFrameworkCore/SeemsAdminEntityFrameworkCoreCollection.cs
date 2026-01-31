using Xunit;

namespace SeemsAdmin.EntityFrameworkCore;

[CollectionDefinition(SeemsAdminTestConsts.CollectionDefinitionName)]
public class SeemsAdminEntityFrameworkCoreCollection : ICollectionFixture<SeemsAdminEntityFrameworkCoreFixture>
{

}
