namespace DomainLayer.Models
{
    public interface IDashboardResponseModel
    {
        DashboardModel Data { get; set; }
        string Message { get; set; }
        bool Success { get; set; }
    }
}