namespace DomainLayer.Models
{
    public interface IProjectStatusModel
    {
        int Active { get; set; }
        int Cancelled { get; set; }
        int Closed { get; set; }
        int Suspended { get; set; }
    }
}