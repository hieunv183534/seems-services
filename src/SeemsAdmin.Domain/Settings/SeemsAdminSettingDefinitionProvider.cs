using Volo.Abp.Settings;

namespace SeemsAdmin.Settings;

public class SeemsAdminSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SeemsAdminSettings.MySetting1));
    }
}
