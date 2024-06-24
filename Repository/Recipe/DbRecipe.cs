using MongoDB.Bson;

namespace YarnRecipees.Service.Repository.Recipe;

public class DbRecipe
{
    public ObjectId Id { get; set; }
    
    public string name { get; set; }
    public string category { get; set; }
    public string yarn { get; set; }
    public string[] sizes { get; set; }
    public string[] needles { get; set; }
    public string difficulty { get; set; }
}