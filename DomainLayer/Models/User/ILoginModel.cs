namespace DomainLayer.Models
{
    public interface ILoginModel
    {
        string Password { get; set; }
        string Username { get; set; }
    }
}