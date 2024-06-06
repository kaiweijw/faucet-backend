using AELFFaucet.MongoDB;
using Volo.Abp.Modularity;

namespace AELFFaucet
{
    [DependsOn(
        typeof(AELFFaucetMongoDbTestModule)
        )]
    public class AELFFaucetDomainTestModule : AbpModule
    {

    }
}