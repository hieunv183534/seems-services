using SeemsAdmin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SeemsAdmin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SeemsAdminController : AbpControllerBase
{
    protected SeemsAdminController()
    {
        LocalizationResource = typeof(SeemsAdminResource);
    }
}
