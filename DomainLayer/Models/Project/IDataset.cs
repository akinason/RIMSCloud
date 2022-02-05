using System;

namespace DomainLayer.Models
{
    public interface IDatasetModel
    {
        bool Archived { get; set; }
        DateTime CreatedAt { get; set; }
        string Description { get; set; }
        int Fields { get; set; }
        int Id { get; set; }
        bool Imported { get; set; }
        bool Locked { get; set; }
        string Name { get; set; }
        object Photo { get; set; }
        int ProdRecordcount { get; set; }
        int StaggingRecordcount { get; set; }
        string Status { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}