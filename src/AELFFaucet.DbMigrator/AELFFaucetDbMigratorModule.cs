using AELFFaucet.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AELFFaucet.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AELFFaucetMongoDbModule),
        typeof(AELFFaucetApplicationContractsModule)
        )]
    public class AELFFaucetDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
        }
    }
}
