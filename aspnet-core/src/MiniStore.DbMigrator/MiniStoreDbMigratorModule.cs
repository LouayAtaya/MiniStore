using MiniStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MiniStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MiniStoreEntityFrameworkCoreModule),
    typeof(MiniStoreApplicationContractsModule)
    )]
public class MiniStoreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
