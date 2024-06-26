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

    public string SubCategory { get; set; }

    public string Needles { get; set; }

    public Dictionary<string, string> YarnNeeded { get; set; }

    public Dictionary<string, string> SizeChart { get; set; }
    
    public string Description { get; set; }

    public string Gauge { get; set; }
    
    public static Recipe MapFromDbRecipe(DbRecipe? recipe)
    {
        return new Recipe
        {
            Id = recipe.Id,
            Name = recipe.name,
            Category = recipe.category,
            SubCategory = recipe.subcategory,
            Needles = recipe.needles,
            Yarn = recipe.yarn,
            Sizes = recipe.sizes,
            SizeChart = recipe.size_chart,
            YarnNeeded = recipe.yarn_needed,
            Gauge = recipe.gauge,
            Description = recipe.description
            
        };
    }
}