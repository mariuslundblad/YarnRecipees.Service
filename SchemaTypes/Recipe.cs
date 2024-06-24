using MongoDB.Bson;
using YarnRecipees.Service.Repository.Recipe;

namespace YarnRecipees.Service.SchemaTypes;

public class Recipe
{
    public ObjectId Id { get; set; }
    public string? Name { get; set; }
    public string Category { get; set; }
    public string Yarn { get; set; }
    public ICollection<string> Sizes { get; set; }
    public ICollection<string> Needles { get; set; }
    public string Difficulty { get; set; }
    
    public static Recipe MapFromDbRecipe(DbRecipe? recipe)
    {
        return new Recipe
        {
            Id = recipe.Id,
            Name = recipe.name,
            Category = recipe.category,
            Yarn = recipe.yarn,
            Sizes = recipe.sizes,
            Needles = recipe.needles,
            Difficulty = recipe.difficulty
        };
    }
}