using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using Zapota.Common;
using Zapota.Entities;

namespace Zapota.DAO
{

    public class WellnessRepository : BaseMongoRepository<Wellness>, IWellnessRepository<Wellness>
    {

        private const string WellnessCollection = "Wellness"; 
        private readonly IMongoDataContext _dataContext;

        public WellnessRepository(IMongoDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        protected override IMongoCollection<Wellness> Collection =>
            _dataContext.MongoDatabase.GetCollection<Wellness>(WellnessCollection);

        public bool Delete(Guid Id)
        {
            var result = base.DeleteAsync(Id);
            return result.IsCompleted;
        }

        public List<Wellness> GetAll()
        {
            var result = base.FindAllAsync(null);
            return result.Result.ToList();
        }

        public Wellness Get(Guid Id)
        {
            var result = base.GetByIdAsync(Id);
            return result.Result;
        }

        public bool Save(Wellness entity)
        {
            var result = base.SaveAsync(entity);
            return result.IsCompleted;
        } 
    }
}
