using Volo.Abp.Reflection;

namespace VNEmsResource.Permissions;

public class VNEmsResourcePermissions
{
    public const string GroupName = "VNEmsResource";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(VNEmsResourcePermissions));
    }
}
