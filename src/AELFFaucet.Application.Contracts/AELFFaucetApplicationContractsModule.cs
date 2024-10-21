using Volo.Abp.Modularity;

namespace AELFFaucet
{
    [DependsOn(
        typeof(AELFFaucetDomainSharedModule)
    )]
    public class AELFFaucetApplicationContractsModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AELFFaucetDtoExtensions.Configure();
        }
    }
}
