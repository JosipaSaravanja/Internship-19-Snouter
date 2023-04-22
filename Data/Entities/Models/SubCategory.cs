using Newtonsoft.Json.Schema;

namespace Data.Entities;

public class SubCategory
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public JSchema Schema { get; set; }
    
}