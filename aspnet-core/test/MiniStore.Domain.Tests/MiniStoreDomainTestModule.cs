using MiniStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MiniStore;

[DependsOn(
    typeof(MiniStoreEntityFrameworkCoreTestModule)
    )]
public class MiniStoreDomainTestModule : AbpModule
{

}
