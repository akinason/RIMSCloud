using System;

namespace DomainLayer.Models
{
    public interface IMemberModel
    {
        UserModel AddedBy { get; set; }
        DateTime CreatedAt { get; set; }
        int Id { get; set; }
        string Permission { get; set; }
        DateTime UpdatedAt { get; set; }
        UserModel User { get; set; }
    }
}