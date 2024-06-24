using MongoDB.Driver;

namespace YarnRecipees.Service.Repository
{
    public class DbConnection : IDisposable
    {
        private readonly MongoClient _connection;

        public DbConnection(string? connectionString)
        {
            if (connectionString == null)
            {
                throw new ArgumentNullException(nameof(connectionString));
            }
            var settings = MongoClientSettings.FromConnectionString(connectionString);
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            
            _connection = new MongoClient(settings);
        }

        public MongoClient Connection => _connection;

        public IEnumerable<T> QueryAsync<T>(string sqlQuery)
        {
            return _connection.GetDatabase("yarn").GetCollection<T>(sqlQuery)
                .AsQueryable();
        }

        public void Dispose()
        {
            // TODO release managed resources here
        }
    }
}