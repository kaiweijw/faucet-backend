using System.Threading.Tasks;

namespace AELFFaucet.Data
{
    public interface IAELFFaucetDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
