using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace AELFFaucet
{
    public class AELFFaucetDomainSharedModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            AELFFaucetGlobalFeatureConfigurator.Configure();
            AELFFaucetModuleExtensionConfigurator.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AELFFaucetDomainSharedModule>();
            });
        }
    }
}
