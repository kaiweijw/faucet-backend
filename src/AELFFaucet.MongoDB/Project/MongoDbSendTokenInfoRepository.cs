using System;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using AELFFaucet.MongoDB;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace AELFFaucet.Project
{
    public class MongoDbSendTokenInfoRepository: MongoDbRepository<AELFFaucetMongoDbContext, SendTokenInfo, string>,
        ISendTokenInfoRepository
    {
        public MongoDbSendTokenInfoRepository(
            IMongoDbContextProvider<AELFFaucetMongoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public override Task<SendTokenInfo> GetAsync(string id, bool includeDetails = true,
             CancellationToken cancellationToken = new CancellationToken())
         {
             return base.FindAsync(SendTokenInfo.FormatId(id), includeDetails, cancellationToken);
        }

         public override Task<SendTokenInfo> InsertAsync(SendTokenInfo entity, bool includeDetails = true,
             CancellationToken cancellationToken = new CancellationToken())
         {
             return base.InsertAsync(entity, includeDetails, cancellationToken);
         }
    }
}