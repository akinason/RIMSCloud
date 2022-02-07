using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{

    public class TokenResponseModel : ITokenResponseModel
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }

    public class TokenRequestModel : ITokenRequestModel
    {

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
        public string Ignore { get; set; } = "";
    }
}
