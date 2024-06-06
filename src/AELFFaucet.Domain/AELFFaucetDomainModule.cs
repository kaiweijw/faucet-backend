using Volo.Abp.Modularity;

namespace AELFFaucet
{
    [DependsOn(
        typeof(AELFFaucetDomainSharedModule)
    )]
    public class AELFFaucetDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

        }
    }
}
