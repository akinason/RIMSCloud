using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class UserModel : IUserModel
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public int Id { get; set; }
        public bool Active { get; set; }
        public string FullName { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }
        public bool Approved { get; set; }
        public RoleModel Role { get; set; }
        public RoleModel[] Roles { get; set; }
        public object Photo { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
