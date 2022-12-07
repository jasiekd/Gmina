using GminaApi.Entity;

namespace Gmina_Api.Entity
{
    public class ApplicationEntity : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
