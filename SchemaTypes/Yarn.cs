using MongoDB.Bson;
using YarnRecipees.Service.Repository.Yarns;

namespace YarnRecipees.Service.SchemaTypes;

public class Yarn
{
    
    public ObjectId Id { get; set; }
    public string Brand { get; set; }
    public string ProductName { get; set; }
    public string Material { get; set; }
    public string LengthPerSkein { get; set; }
    public string Weight { get; set; }
    public string NeedleSize { get; set; }
    public string StitchesPer10cm { get; set; }
    
    public string[] Colors { get; set; }
    
    public static Yarn MapFromDbYarn(DbYarn? yarn)
    {
        return new Yarn
        {
            Id = yarn.Id,
            Brand = yarn.brand,
            ProductName = yarn.product_name,
            Material = yarn.material,
            LengthPerSkein = yarn.length_per_skein,
            Weight = yarn.weight,
            NeedleSize = yarn.needle_size,
            StitchesPer10cm = yarn.stitches_per_10cm,
            Colors = yarn.colors
        };
    }
}
