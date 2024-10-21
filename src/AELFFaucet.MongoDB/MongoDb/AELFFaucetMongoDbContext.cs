
using AELFFaucet.Project;
using MongoDB.Driver;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace AELFFaucet.MongoDB
{
    [ConnectionStringName("Default")]
    public class AELFFaucetMongoDbContext : AbpMongoDbContext
    {
        public IMongoCollection<SendTokenInfo> SendTokenInfo => Collection<SendTokenInfo>();
    }
}
