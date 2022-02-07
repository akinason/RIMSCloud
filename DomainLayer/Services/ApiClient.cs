using CommonLayer;
using DomainLayer.Models;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System.Configuration;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


namespace DomainLayer.Services
{
   
    public class ApiClient
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

        private static string baseUrl = "https://api.rimscloud.co"; //ConfigurationManager.AppSettings.Get("baseURL");
        private static RestClient _client;
        public static string Token { get; set; }
        public static string RefreshToken { get; set; }

       
       public ApiClient ()
        {
            this.SetupClient();
        }

        private void SetupClient()
        {
            if (_client == null)
            {
                _client = new RestClient(baseUrl: baseUrl);
            }

            if (Token != null)
            {
                _client.Authenticator = new OAuth2AuthorizationRequestHeaderAuthenticator(Token, "bearer");
            }

        }

        public async Task<RestResponse> ExecuteAsync(RestRequest request, Method httpMethod, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.SetupClient();

            var response = await _client.ExecuteAsync(request, httpMethod, cancellationToken);
            
            if (((int)response.StatusCode) == 401 && request.Resource != "/v1/auth/token" && request.Resource != "/v1/auth/refresh") // Get a refresh token
            {
                await this.GetNewTokenUsingRefreshToken();
                response = await _client.ExecuteAsync(request, httpMethod, cancellationToken); // Run the request again using new token credentails.
            }
            return (RestResponse)response;
        }

        public async Task GetNewTokenUsingRefreshToken()
        {
            if (RefreshToken == null) return;

            TokenRequestModel model = new TokenRequestModel();
            model.RefreshToken = RefreshToken;
            var json = JsonConvert.SerializeObject(model);
            RestRequest request = new RestRequest("/v1/auth/refresh", Method.Post).AddStringBody(json, DataFormat.Json);
            var response = await this.ExecuteAsync(request, Method.Post);

            if (response.IsSuccessful)
            {
                var responseModel = JsonConvert.DeserializeObject<TokenResponseModel>(response.Content);
                Token = responseModel.AccessToken;
                RefreshToken = responseModel.RefreshToken;
                this.SetupClient();
            }
           
        }
    }

}
