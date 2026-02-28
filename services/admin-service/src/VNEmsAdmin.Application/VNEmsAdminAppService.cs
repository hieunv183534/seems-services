using System;
using System.Collections.Generic;
using System.Text;
using VNEmsAdmin.Localization;
using Volo.Abp.Application.Services;

namespace VNEmsAdmin;

/* Inherit your application services from this class.
 */
public abstract class VNEmsAdminAppService : ApplicationService
{
    protected VNEmsAdminAppService()
    {
        LocalizationResource = typeof(VNEmsAdminResource);
    }
}
