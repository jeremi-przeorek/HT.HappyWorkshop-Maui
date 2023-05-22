using SQLite;

namespace HT.MauiWorkshop.Repository;

public class CarEntity
{
    [PrimaryKey]
    [AutoIncrement]
    public int Id { get; set; }
    
    [MaxLength(25)]
    public string Make { get; set; }
    
    [MaxLength(25)]
    public string Model { get; set; }
    
    [MaxLength(4)]
    public string Year { get; set; }
    
    [MaxLength(10)]
    public string Price { get; set; }
}