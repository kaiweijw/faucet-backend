using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;
using Volo.Abp.Uow;

namespace AELFFaucet.MongoDB
{
    [DependsOn(
        typeof(AELFFaucetDomainModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpMongoDbModule)
    )]
    public class AELFFaucetMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<AELFFaucetMongoDbContext>(options =>
            {
                options.AddDefaultRepositories();
            });
            
            Configure<AbpUnitOfWorkDefaultOptions>(options =>
            {
                options.TransactionBehavior = UnitOfWorkTransactionBehavior.Disabled;
            });
        }
    }
}
