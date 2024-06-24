using MongoDB.Bson;

namespace YarnRecipees.Service.Repository.Yarns;

public class DbYarn
{
    public ObjectId Id { get; set; }
    public string brand { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public string composition { get; set; }
    public string length { get; set; }
    public string weight { get; set; }
    public string recommended_needle_size { get; set; }
    public string gauge { get; set; }
    public string care_instructions { get; set; }
    
    public DbYarnColor[] colors { get; set; }
}

public class DbYarnColor
{
    public string name { get; set; }
    public string color_code { get; set; }
}