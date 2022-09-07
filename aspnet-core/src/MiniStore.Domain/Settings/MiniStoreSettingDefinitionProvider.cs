using Volo.Abp.Settings;

namespace MiniStore.Settings;

public class MiniStoreSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MiniStoreSettings.MySetting1));
    }
}
