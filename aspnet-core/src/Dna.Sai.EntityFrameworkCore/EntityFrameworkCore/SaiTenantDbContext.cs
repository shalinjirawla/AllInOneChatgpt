using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace Dna.Sai.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class SaiTenantDbContext : SaiDbContextBase<SaiTenantDbContext>
{
    public SaiTenantDbContext(DbContextOptions<SaiTenantDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Tenant);

        base.OnModelCreating(builder);
    }
}
