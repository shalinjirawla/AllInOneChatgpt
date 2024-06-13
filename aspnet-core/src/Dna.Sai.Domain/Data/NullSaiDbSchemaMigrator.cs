using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Dna.Sai.Data;

/* This is used if database provider does't define
 * ISaiDbSchemaMigrator implementation.
 */
public class NullSaiDbSchemaMigrator : ISaiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
