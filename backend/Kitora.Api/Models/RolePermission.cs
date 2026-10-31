namespace Kitora.Api.Models;

public class RolePermission()
{
    public int Id { get; set; }
    public int Role_id { get; set; }
    public int Permission_id { get; set; }
    public DateTime Created_at { get; set; } = DateTime.UtcNow;
    public DateTime Updated_at { get; set; } = DateTime.UtcNow;

    public Role? Role { get; set; }
    public Permission? Permission { get; set; }
}