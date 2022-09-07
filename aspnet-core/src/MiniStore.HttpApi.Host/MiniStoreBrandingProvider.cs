using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MiniStore;

[Dependency(ReplaceServices = true)]
public class MiniStoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MiniStore";
}
