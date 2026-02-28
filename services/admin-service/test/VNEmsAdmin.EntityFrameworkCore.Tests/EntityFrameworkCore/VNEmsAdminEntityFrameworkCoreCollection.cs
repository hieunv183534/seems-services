using Xunit;

namespace VNEmsAdmin.EntityFrameworkCore;

[CollectionDefinition(VNEmsAdminTestConsts.CollectionDefinitionName)]
public class VNEmsAdminEntityFrameworkCoreCollection : ICollectionFixture<VNEmsAdminEntityFrameworkCoreFixture>
{

}
