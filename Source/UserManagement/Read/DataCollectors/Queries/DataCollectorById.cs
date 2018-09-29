using System.Linq;
using Concepts;
using Concepts.DataCollector;
using Dolittle.Queries;
using Read.DataCollectors.Migration;
using Infrastructure.Read.MongoDb;

namespace Read.DataCollectors.Queries
{
    public class DataCollectorById : IQueryFor<DataCollector>
    {
        readonly IDataCollectors _repository;

        public DataCollectorId DataCollectorId { get; set; }

        public DataCollectorById(IDataCollectors repository)
        {
            _repository = repository;
        }
        
        public IQueryable<DataCollector> Query => _repository.Query.Where(d => d.Id == DataCollectorId);
    }
}