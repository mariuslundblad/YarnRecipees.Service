namespace YarnRecipees.Service.Repository.Yarns;

public class YarnRepository
{
    private readonly DbConnection _dbConnection;
    
    public YarnRepository(DbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    
    public IEnumerable<DbYarn> GetYarns()
    {
        var dbBooks = _dbConnection.QueryAsync<DbYarn>("yarn");
        return dbBooks;
    }
}