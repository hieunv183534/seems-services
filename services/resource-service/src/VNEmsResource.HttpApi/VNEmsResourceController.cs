using VNEmsResource.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VNEmsResource;

public abstract class VNEmsResourceController : AbpControllerBase
{
    protected VNEmsResourceController()
    {
        LocalizationResource = typeof(VNEmsResourceResource);
    }
}
