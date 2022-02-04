using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
   
    public class TokenResponseModel
    {
        [JsonProperty("acces_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }

    public class TokenRequestModel
    {

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
