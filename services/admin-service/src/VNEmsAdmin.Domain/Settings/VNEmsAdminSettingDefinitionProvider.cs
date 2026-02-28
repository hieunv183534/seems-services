using Volo.Abp.Settings;

namespace VNEmsAdmin.Settings;

public class VNEmsAdminSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(VNEmsAdminSettings.MySetting1));
    }
}
