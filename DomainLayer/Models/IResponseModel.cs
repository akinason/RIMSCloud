using System.Collections.Generic;

namespace DomainLayer.Models
{
    public interface IResponseModel
    {
        //object Data { get; set; } 
        string Message { get; set; }
        bool Success { get; set; }
    }
}