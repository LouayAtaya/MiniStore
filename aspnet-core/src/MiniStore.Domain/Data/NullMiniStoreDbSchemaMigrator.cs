using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MiniStore.Data;

/* This is used if database provider does't define
 * IMiniStoreDbSchemaMigrator implementation.
 */
public class NullMiniStoreDbSchemaMigrator : IMiniStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
