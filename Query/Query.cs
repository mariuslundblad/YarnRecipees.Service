using YarnRecipees.Service.Repository.Recipe;
using YarnRecipees.Service.Repository.Yarns;
using YarnRecipees.Service.SchemaTypes;

namespace YarnRecipees.Service.Query;

public class Query
{
    public async Task<IEnumerable<Yarn>> GetYarns([Service]YarnRepository repository)
    {
        var dbYarn = repository.GetYarns();
        return dbYarn.Select(Yarn.MapFromDbYarn);
    }
    
    public async Task<IEnumerable<Recipe>> GetRecipes([Service]RecipeRepository repository)
    {
        var dbRecipes = repository.GetRecipes();
        return dbRecipes.Select(Recipe.MapFromDbRecipe);
    }
}