using Dna.Sai.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Dna.Sai;

[DependsOn(
    typeof(SaiEntityFrameworkCoreTestModule)
    )]
public class SaiDomainTestModule : AbpModule
{

}
