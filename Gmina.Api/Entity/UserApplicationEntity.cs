using GminaApi.Entity;


    public class UserApplicationEntity : IEntity
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int? ApplicationId { get; set; }
        public virtual ApplicationEntity Application { get; set; }
        public DateTime DatePosted { get; set; }
        public int ClerkId { get; set; }
        public string Status { get; set; }
        public DateTime DateModified { get; set; }
        public string Description { get; set; }
    }

