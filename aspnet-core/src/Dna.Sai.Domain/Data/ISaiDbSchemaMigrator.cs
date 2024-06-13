using System.Threading.Tasks;

namespace Dna.Sai.Data;

public interface ISaiDbSchemaMigrator
{
    Task MigrateAsync();
}
