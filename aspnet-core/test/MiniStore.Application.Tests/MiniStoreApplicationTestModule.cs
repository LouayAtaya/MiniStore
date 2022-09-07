using Volo.Abp.Modularity;

namespace MiniStore;

[DependsOn(
    typeof(MiniStoreApplicationModule),
    typeof(MiniStoreDomainTestModule)
    )]
public class MiniStoreApplicationTestModule : AbpModule
{

}
