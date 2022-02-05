namespace DomainLayer.Models
{
    public interface ITokenResponseModel
    {
        string AccessToken { get; set; }
        string RefreshToken { get; set; }
        string TokenType { get; set; }
    }
}