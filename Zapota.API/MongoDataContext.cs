using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Zapota.Common;

namespace Zopata.API
{
    public class MongoDataContext : IMongoDataContext
    {
        private readonly IOptions<AppSettings> settings;

        public MongoDataContext(IOptions<AppSettings> settings)
            : this("MongoDb")
        {
            this.settings = settings;
        }

        public MongoDataContext(string connectionName)
        {

            var url = "mongodb://zapota:zapotaml123@ds030817.mlab.com:30817/zapota";// settings.Value.MongoDB;
            var mongoUrl = new MongoUrl(url);
            IMongoClient client = new MongoClient(mongoUrl);
            MongoDatabase = client.GetDatabase(mongoUrl.DatabaseName);
        }

        public IMongoDatabase MongoDatabase { get; }
    }
}
