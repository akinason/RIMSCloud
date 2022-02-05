namespace DomainLayer.Models
{
    public interface IDashboardModel
    {
        GraphDataModel[] GraphData { get; set; }
        ProjectStatusModel ProjectStatus { get; set; }
        ProjectModel[] RecentProjects { get; set; }
    }
}