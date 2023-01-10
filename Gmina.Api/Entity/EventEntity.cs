using GminaApi.Entity;


    public class EventEntity : IEntity
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public int ClerkId { get; set; }
    }
