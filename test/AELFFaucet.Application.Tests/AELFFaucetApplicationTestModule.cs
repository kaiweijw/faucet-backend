using Volo.Abp.Modularity;

namespace AELFFaucet
{
    [DependsOn(
        typeof(AELFFaucetApplicationModule),
        typeof(AELFFaucetDomainTestModule)
        )]
    public class AELFFaucetApplicationTestModule : AbpModule
    {

    }
}