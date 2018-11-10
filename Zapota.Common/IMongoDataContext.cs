using MongoDB.Driver;

namespace Zapota.Common
{
    public interface IMongoDataContext
    {
        IMongoDatabase MongoDatabase { get; }
    }
}