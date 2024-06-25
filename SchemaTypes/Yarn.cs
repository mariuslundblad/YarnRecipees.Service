using MongoDB.Bson;
using YarnRecipees.Service.Repository.Yarns;

namespace YarnRecipees.Service.SchemaTypes;

public class Yarn
{
    
    public ObjectId Id { get; set; }
    public string Brand { get; set; }
    public string Name { get; set; }
    public string Composition { get; set; }
    public string LengthPerSkein { get; set; }
    public string Weight { get; set; }
    public string RecommendedNeedleSize { get; set; }
    public string Gauge { get; set; }
    
    public string[] Colors { get; set; }
    
    public static Yarn MapFromDbYarn(DbYarn? yarn)
    {
        return new Yarn
        {
            Id = yarn.Id,
            Brand = yarn.brand,
            Name = yarn.product_name,
            Composition = yarn.material,
            LengthPerSkein = yarn.length_per_skein,
            Weight = yarn.weight,
            RecommendedNeedleSize = yarn.needle_size,
            Gauge = yarn.stitches_per_10cm,
            Colors = yarn.colors
        };
    }
}
