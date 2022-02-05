using Newtonsoft.Json;


namespace DomainLayer.Models
{
    public class DashboardResponseModel : IResponseModel, IDashboardResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public DashboardModel Data { get; set; }
    }

    public class DashboardModel : IDashboardModel
    {
        [JsonProperty("recent_projects")]
        public ProjectModel[] RecentProjects { get; set; }

        [JsonProperty("project_status")]
        public ProjectStatusModel ProjectStatus { get; set; }

        [JsonProperty("graph_data")]
        public GraphDataModel[] GraphData { get; set; }
    }

    public class GraphDataModel : IGraphDataModel
    {
        public int Count { get; set; }
        public string Date { get; set; }
    }

    public class ProjectStatusModel : IProjectStatusModel
    {
        public int Active { get; set; }
        public int Cancelled { get; set; }
        public int Closed { get; set; }
        public int Suspended { get; set; }
    }
}
