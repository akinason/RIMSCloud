using System;

namespace DomainLayer.Models
{
    public interface IUserModel
    {
        bool Active { get; set; }
        bool Approved { get; set; }
        DateTime CreatedAt { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string FullName { get; set; }
        int Id { get; set; }
        bool IsVerified { get; set; }
        string LastName { get; set; }
        object Photo { get; set; }
        RoleModel Role { get; set; }
        RoleModel[] Roles { get; set; }
        DateTime UpdatedAt { get; set; }
        string Username { get; set; }
    }
}