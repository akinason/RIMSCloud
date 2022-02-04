using DomainLayer.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;


namespace DomainLayer.Services
{
    /* Base class for interacting with RIMS API
     Usage:
        ApiClient client = new ApiClient(); // Returns a RestClient configured with default params.
        const json = "{username: \"<username>\", password: \"<password>\"}"
        RestRequest request = new RestRequest("/auth/token", Method.Post).AddJsonBody(json);
        
        var response = await client.ExecuteAsync(request); // Returns a RestResponse instance.
        if (response.IsSuccessful) {
            // do something with success data
            var responseModel = JsonConvert.DeserializeObject<MyModel>(response.Content);
        } 
        else 
        {
            // do something with failed response.
        }
     */

    public class ApiClient
    {
        private static string baseUrl = ConfigurationManager.AppSettings["baseURL"];
        private static RestClient _client;
        public static string Token { get; set; }
        public static string RefreshToken { get; set; }

        public static RestClient GetRestClient()
        {
            ApiClient apiClient = new ApiClient();
            apiClient.SetupClient();
            return _client;
        }

        private void SetupClient()
        {
            if (_client == null)
            {
                _client = new RestClient(baseUrl: baseUrl);
            }

            if (Token != null)
            {
                _client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Token);
            }
           
        }

        //public async Task<RestResponse<T>> ExecuteAsync<T>(RestRequest request, Method httpMethod, CancellationToken cancellationToken = default(CancellationToken)) 
        //{
        //    this.SetupClient();
        //    var response = await _client.ExecuteAsync<T>(request, httpMethod, cancellationToken);
        //    return response;
        //}
        public async Task<RestResponse> ExecuteAsync(RestRequest request, Method httpMethod, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.SetupClient();
            var response = await _client.ExecuteAsync(request, httpMethod, cancellationToken);
            
            if (((int)response.StatusCode) == 401 && request.Resource != "/auth/token" && request.Resource != "/auth/refresh") // Get a refresh token
            {
                this.GetNewTokenUsingRefreshToken();
                response = await _client.ExecuteAsync(request, httpMethod, cancellationToken); // Run the request again using new token credentails.
            }
            return (RestResponse)response;
        }

        private async void GetNewTokenUsingRefreshToken()
        {
            if (RefreshToken == null) return;

            TokenRequestModel model = new TokenRequestModel();
            model.RefreshToken = RefreshToken;
            RestRequest request = new RestRequest("/auth/refresh", Method.Post).AddBody(model);
            var response = await this.ExecuteAsync(request, Method.Post);
            if (response.IsSuccessful)
            {
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponseModel>(response.Content);
                Token = tokenResponse.AccessToken;
                RefreshToken = tokenResponse.RefreshToken;
                this.SetupClient();
            }
        }
    }

}
