using MongoDB.Bson;

namespace YarnRecipees.Service.Repository.Recipe;

public class DbRecipe
{
    public ObjectId Id { get; set; }
    
    public string name { get; set; }
    public string category { get; set; }
    public string subcategory { get; set; }
    public string description { get; set; }
    public string yarn { get; set; }
    public string needles { get; set; }
    public string[] sizes { get; set; }
    public string gauge { get; set; }
    public Dictionary<string, string> size_chart { get; set; }
    public Dictionary<string, string> yarn_needed { get; set; }
    public string image_url { get; set; }
}