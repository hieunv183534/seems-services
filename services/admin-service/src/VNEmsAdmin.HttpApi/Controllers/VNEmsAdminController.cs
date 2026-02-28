using VNEmsAdmin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VNEmsAdmin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class VNEmsAdminController : AbpControllerBase
{
    protected VNEmsAdminController()
    {
        LocalizationResource = typeof(VNEmsAdminResource);
    }
}
