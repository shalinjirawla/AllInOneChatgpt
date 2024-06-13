using Dna.Sai.ChatHistory;
using Dna.Sai.PromptMasters;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.MultiTenancy;

namespace Dna.Sai.EntityFrameworkCore;

[ConnectionStringName("Default")]
public class SaiDbContext : SaiDbContextBase<SaiDbContext>
{
    public DbSet<PromptMaster> PromptMasters { get; set; }
    public DbSet<History> Histories { get; set; }
    public SaiDbContext(DbContextOptions<SaiDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.SetMultiTenancySide(MultiTenancySides.Both);

        base.OnModelCreating(builder);
    }
}
