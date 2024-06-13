using Volo.Abp.Modularity;

namespace Dna.Sai;

[DependsOn(
    typeof(SaiApplicationModule),
    typeof(SaiDomainTestModule)
    )]
public class SaiApplicationTestModule : AbpModule
{

}
