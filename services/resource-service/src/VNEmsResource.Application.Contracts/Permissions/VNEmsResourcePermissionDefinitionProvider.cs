using VNEmsResource.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VNEmsResource.Permissions;

public class VNEmsResourcePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(VNEmsResourcePermissions.GroupName, L("Permission:VNEmsResource"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<VNEmsResourceResource>(name);
    }
}
