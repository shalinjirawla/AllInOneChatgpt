using Microsoft.EntityFrameworkCore;

namespace Dna.Sai.EntityFrameworkCore;

public class SaiTenantDbContextFactory :
    SaiDbContextFactoryBase<SaiTenantDbContext>
{
    protected override SaiTenantDbContext CreateDbContext(
        DbContextOptions<SaiTenantDbContext> dbContextOptions)
    {
        return new SaiTenantDbContext(dbContextOptions);
    }
}
