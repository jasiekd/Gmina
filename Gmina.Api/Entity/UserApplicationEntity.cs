using GminaApi.Entity;

namespace Gmina_Api.Entity
{
    public class UserApplicationEntity : IEntity
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int ApplicationId { get; set; }
        public DateTime DatePosted { get; set; }
        public int ClerkId { get; set; }
        public string Status { get; set; }
        public DateTime DateModified { get; set; }
        public string Description { get; set; }
    }
}
