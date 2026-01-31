using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace SeemsAdmin;

[Dependency(ReplaceServices = true)]
public class SeemsAdminBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SeemsAdmin";
}
