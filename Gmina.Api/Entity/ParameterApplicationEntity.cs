using GminaApi.Entity;

namespace Gmina_Api.Entity
{
    public class ParameterApplicationEntity : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int ApplicationId { get; set; }
    }
}
