using VNEmsResource.Localization;
using Volo.Abp.Application.Services;

namespace VNEmsResource;

public abstract class VNEmsResourceAppService : ApplicationService
{
    protected VNEmsResourceAppService()
    {
        LocalizationResource = typeof(VNEmsResourceResource);
        ObjectMapperContext = typeof(VNEmsResourceApplicationModule);
    }
}
