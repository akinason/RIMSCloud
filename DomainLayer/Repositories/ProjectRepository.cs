using DomainLayer.Models;
using DomainLayer.Services;
using Newtonsoft.Json;
using RestSharp;
using System.IO;
using System.Threading.Tasks;

namespace DomainLayer.Repositories
{
    public class ProjectRepository
    {
        private ApiClient _client;
        
        public ProjectRepository()
        {
            this._client = new ApiClient();
        }

        public async Task<(bool, ProjectModel)> GetProjectById(int id)
        {
            RestRequest request = new RestRequest($"/v1/projects/{id}", Method.Get);
            var response = await _client.ExecuteAsync(request, Method.Get);
            if (response.IsSuccessful)
            {
                ProjectResponseModel responseModel = JsonConvert.DeserializeObject<ProjectResponseModel>(response.Content);
                ProjectModel projectModel = responseModel.Data;
                return (true, projectModel);
            }
            else
            {
                return (false, null);
            }
        }
    }
}
