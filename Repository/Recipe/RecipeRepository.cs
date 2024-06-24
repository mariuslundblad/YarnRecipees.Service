namespace YarnRecipees.Service.Repository.Recipe;

public class RecipeRepository
{
    private readonly DbConnection _dbConnection;
    
    public RecipeRepository(DbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }
    
    public IEnumerable<DbRecipe> GetRecipes()
    {
        var dbRecipes = _dbConnection.QueryAsync<DbRecipe>("Recipe");
        return dbRecipes;
    }
}