using System.Threading.Tasks;

namespace MiniStore.Data;

public interface IMiniStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
