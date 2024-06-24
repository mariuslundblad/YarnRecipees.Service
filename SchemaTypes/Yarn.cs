using MongoDB.Bson;
using YarnRecipees.Service.Repository.Yarns;

namespace YarnRecipees.Service.SchemaTypes;

public class Yarn
{
    
    public ObjectId Id { get; set; }
    public string Brand { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Composition { get; set; }
    public string Length { get; set; }
    public string Weight { get; set; }
    public string RecommendedNeedleSize { get; set; }
    public string Gauge { get; set; }
    public string CareInstructions { get; set; }
    
    public ICollection<YarnColor> Colors { get; set; }
    
    public static Yarn MapFromDbYarn(DbYarn? yarn)
    {
        return new Yarn
        {
            Id = yarn.Id,
            Brand = yarn.brand,
            Name = yarn.name,
            Description = yarn.description,
            Composition = yarn.composition,
            Length = yarn.length,
            Weight = yarn.weight,
            RecommendedNeedleSize = yarn.recommended_needle_size,
            Gauge = yarn.gauge,
            CareInstructions = yarn.care_instructions,
            Colors = yarn.colors.Select(color => new YarnColor
            {
                Name = color.name,
                ColorCode = color.color_code
            }).ToList()
        };
    }
}

public class YarnColor
{
    public string Name { get; set; }
    public string ColorCode { get; set; }
}