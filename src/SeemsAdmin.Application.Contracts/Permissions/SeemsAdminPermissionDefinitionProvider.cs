using SeemsAdmin.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SeemsAdmin.Permissions;

public class SeemsAdminPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SeemsAdminPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SeemsAdminPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SeemsAdminResource>(name);
    }
}
