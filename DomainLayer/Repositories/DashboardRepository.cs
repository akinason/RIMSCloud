using DomainLayer.Models;
using DomainLayer.Services;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Repositories
{
    public class DashboardRepository
    {
        
        public async Task<IDashboardModel> GetDasbhoardData()
        {
            RestRequest request = new RestRequest("/analytics/dashboard");
            ApiClient client = new ApiClient();
            var response = await client.ExecuteAsync(request, Method.Get);
            if (response.IsSuccessful)
            {
                IDashboardResponseModel responseModel = JsonConvert.DeserializeObject<DashboardResponseModel>(response.Content);
                IDashboardModel dashboardModel = responseModel.Data;
                return dashboardModel;
            }
            else
            {
                return null;
            }
        }

    }
}
