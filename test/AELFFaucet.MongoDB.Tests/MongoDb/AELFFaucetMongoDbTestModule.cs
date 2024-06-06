using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace AELFFaucet.MongoDB
{
    [DependsOn(
        typeof(AELFFaucetTestBaseModule),
        typeof(AELFFaucetMongoDbModule)
        )]
    public class AELFFaucetMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var connectionString = AELFFaucetMongoDbFixture.ConnectionString.EnsureEndsWith('/')  +
                                   "Db_" +
                                   Guid.NewGuid().ToString("N");

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });

            Configure<AbpUnitOfWorkDefaultOptions>(options =>
            {
                options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
            });
        }
    }
}
