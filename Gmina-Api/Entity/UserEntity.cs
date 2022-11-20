using Microsoft.AspNetCore.Identity;
using System.Net;
using System.Security.Policy;

namespace Gmina_Api.Entity
{
    public class UserEntity : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int RoleId { get; set; }
        public RoleEntity Role { get; set; }

    }
}
