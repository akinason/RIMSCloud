using System;

namespace DomainLayer.Models
{
    public interface IProjectModel
    {
        bool Archived { get; set; }
        object BannerPhoto { get; set; }
        DateTime CreatedAt { get; set; }
        DatasetModel[] Datasets { get; set; }
        string Description { get; set; }
        DateTime DueDate { get; set; }
        int Id { get; set; }
        MemberModel[] Members { get; set; }
        string Name { get; set; }
        object ProfilePhoto { get; set; }
        string[] ProjectTags { get; set; }
        string Status { get; set; }
        DateTime UpdatedAt { get; set; }
        UserModel User { get; set; }
    }
}