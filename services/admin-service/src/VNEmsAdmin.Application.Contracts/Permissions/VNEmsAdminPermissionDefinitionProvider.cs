using VNEmsAdmin.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VNEmsAdmin.Permissions;

public class VNEmsAdminPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(VNEmsAdminPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(VNEmsAdminPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<VNEmsAdminResource>(name);
    }
}
