using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
  
    public class ProjectResponseModel : IResponseModel
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public ProjectModel Data { get; set; }
    }

    public class ProjectModel : IProjectModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonProperty("due_date")]
        public DateTime DueDate { get; set; }
        public int Id { get; set; }
        public UserModel User { get; set; }
        public string Status { get; set; }

        [JsonProperty("project_tags")]
        public string[] ProjectTags { get; set; }
        public DatasetModel[] Datasets { get; set; }
        public bool Archived { get; set; }
        public MemberModel[] Members { get; set; }

        [JsonProperty("banner_photo")]
        public object BannerPhoto { get; set; }

        [JsonProperty("profile_photo")]
        public object ProfilePhoto { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }



    public class DatasetModel : IDatasetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonProperty("prod_recordcount")]
        public int ProdRecordcount { get; set; }

        [JsonProperty("stagging_recordcount")]
        public int StaggingRecordcount { get; set; }
        public string Status { get; set; }
        public bool Imported { get; set; }
        public bool Archived { get; set; }
        public int Fields { get; set; }
        public bool Locked { get; set; }
        public object Photo { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

    public class MemberModel : IMemberModel
    {
        public int Id { get; set; }
        public UserModel User { get; set; }
        public UserModel AddedBy { get; set; }
        public string Permission { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }

}
