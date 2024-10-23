using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AELFFaucet.Data
{
    /* This is used if database provider does't DeFine
     * IAELFFaucetDbSchemaMigrator implementation.
     */
    public class NullAELFFaucetDbSchemaMigrator : IAELFFaucetDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}