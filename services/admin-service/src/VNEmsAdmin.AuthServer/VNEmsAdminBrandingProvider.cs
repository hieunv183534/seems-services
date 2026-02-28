using Microsoft.Extensions.Localization;
using VNEmsAdmin.Localization;
using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace VNEmsAdmin;

[Dependency(ReplaceServices = true)]
public class VNEmsAdminBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<VNEmsAdminResource> _localizer;

    public VNEmsAdminBrandingProvider(IStringLocalizer<VNEmsAdminResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
