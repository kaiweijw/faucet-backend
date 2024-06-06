
using AELFFaucet.Project;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AELFFaucet
{
    [DependsOn(
        typeof(AELFFaucetDomainModule),
        typeof(AELFFaucetApplicationContractsModule),
        typeof(AbpLocalizationModule),
        typeof(AbpVirtualFileSystemModule)
    )]
    public class AELFFaucetApplicationModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            var configuration = context.Services.GetConfiguration();
            Configure<ApiConfigOptions>(configuration.GetSection("ApiConfig"));
        }
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<AELFFaucetApplicationModule>();
            });
            context.Services.AddSingleton<OtherTokenSendContractService>();
            context.Services.AddSingleton<NftSeedTokenSendContractService>();

            context.Services.AddSingleton<ITokenSendContractService>(sp => sp.GetRequiredService<OtherTokenSendContractService>());
            context.Services.AddSingleton<ITokenSendContractService>(sp => sp.GetRequiredService<NftSeedTokenSendContractService>());
        }
    }
}
