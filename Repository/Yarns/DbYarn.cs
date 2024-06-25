using MongoDB.Bson;

namespace YarnRecipees.Service.Repository.Yarns;

public class DbYarn
{
    public ObjectId Id { get; set; }
    public string brand { get; set; }
    public string product_name { get; set; }
    public string material { get; set; }
    public string length_per_skein { get; set; }
    public string weight { get; set; }
    public string needle_size { get; set; }
    public string stitches_per_10cm { get; set; }
    public string[] colors { get; set; }
    
}
