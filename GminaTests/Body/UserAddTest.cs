using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GminaApi.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace GminaTests.Body
{
    [TestClass()]
    public class UserAddTest
    {
        [TestMethod()]
        public void userAddTest()
        {
            UserEntity tempUser = new UserEntity
            {
                ID = 12324,
                Name = "Jan",
                Surname = "Nowak",
                BirthDate = new DateTime(2001, 8, 18),
                Email = "test.test@mail.com",
                Login = "login123",
                Password = "123456",
                PhoneNumber = "515234760",
                HouseNumber = "1432",
                Street = "Szeroka",
                ZipCode = "27-325",
                Pesel = "12345678901",
                Town = "Kielce",
                RoleId = 2,
            };
            //sprawdza czy numer telefonu ma odpowiednia dlugosc
            Assert.IsTrue(tempUser.PhoneNumber.Length==9);

            //sprawdza czy urzednik jest pełnoletni
            if(tempUser.RoleId==2)
                Assert.IsTrue(tempUser.BirthDate < DateTime.Now.AddYears(-18));

            //sprawdza czy numer pesel ma odpowiednia dlugosc
            Assert.IsTrue(tempUser.Pesel.Length == 11);

            //sprawdza czy kod pocztowy ma poprawny format
            var r = new Regex(@"^\d{2}-\d{3}$");
            Assert.IsTrue(r.IsMatch(tempUser.ZipCode));
            
            //sprawdza czy email ma poprawny format
            var rEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Assert.IsTrue(rEmail.IsMatch(tempUser.Email));
        }
    }
}
