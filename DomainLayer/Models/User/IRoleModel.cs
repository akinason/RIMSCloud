namespace DomainLayer.Models
{
    public interface IRoleModel
    {
        string Code { get; set; }
        int Key { get; set; }
        string Name { get; set; }
    }
}