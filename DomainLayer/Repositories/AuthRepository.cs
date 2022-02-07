using DomainLayer.Models;
using DomainLayer.Services;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.Threading.Tasks;

namespace DomainLayer.Repositories
{
    public class AuthRepository
    {
        public async Task<bool> Login (ILoginModel loginModel)
        {
            ApiClient client = new ApiClient();
            RestRequest request = new RestRequest("/v1/auth/token", Method.Post).AddBody(loginModel);

            var response = await client.ExecuteAsync(request, Method.Post);
            if (response.IsSuccessful)
            {
                var responseModel = JsonConvert.DeserializeObject<TokenResponseModel>(response.Content);
                ApiClient.Token = responseModel.AccessToken;
                ApiClient.RefreshToken = responseModel.RefreshToken;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
