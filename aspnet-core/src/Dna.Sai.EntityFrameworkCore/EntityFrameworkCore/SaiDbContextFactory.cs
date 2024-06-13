using Microsoft.EntityFrameworkCore;

namespace Dna.Sai.EntityFrameworkCore;

public class SaiDbContextFactory :
    SaiDbContextFactoryBase<SaiDbContext>
{
    protected override SaiDbContext CreateDbContext(
        DbContextOptions<SaiDbContext> dbContextOptions)
    {
        return new SaiDbContext(dbContextOptions);
    }
}
