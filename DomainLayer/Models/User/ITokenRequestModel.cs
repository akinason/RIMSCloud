namespace DomainLayer.Models
{
    public interface ITokenRequestModel
    {
        string RefreshToken { get; set; }
        string Ignore { get; set; } 
    }
}