using System;
using System.Collections.Generic;
using System.Text;
using SeemsAdmin.Localization;
using Volo.Abp.Application.Services;

namespace SeemsAdmin;

/* Inherit your application services from this class.
 */
public abstract class SeemsAdminAppService : ApplicationService
{
    protected SeemsAdminAppService()
    {
        LocalizationResource = typeof(SeemsAdminResource);
    }
}
