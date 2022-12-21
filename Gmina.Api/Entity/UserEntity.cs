namespace GminaApi.Entity
{
    public class UserEntity : IEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime BirthDate { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Town { get; set; }
        public string ZipCode { get; set; }
        public int RoleId { get; set; }
        //public RoleEntity Role { get; set; }

    }
}
