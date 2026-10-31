namespace Kitora.Api.Models;

public class Role()
{
    public int Id { get; set; }
    public String Name { get; set; } = String.Empty;
    public String Description { get; set; } = String.Empty;
    public DateTime Created_at { get; set; } = DateTime.UtcNow;
    public DateTime Updated_at { get; set; } = DateTime.UtcNow;
}