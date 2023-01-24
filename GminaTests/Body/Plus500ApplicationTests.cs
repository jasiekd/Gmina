using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gmina.Body;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using GminaApi.Migrations;

namespace Gmina.Body.Tests
{
    [TestClass()]
    public class Plus500ApplicationTests
    {
        [TestMethod()]
        public void send500PlusApp_ClickTest()
        {
            var applicationBuilder = new ApplicationBuilder()
                .setApplicationID(1)
                .setUserID(1)
                .setDatedOfApplication(DateTime.Now)
                .setApplicationType(ApplicationType.Plus500)
                .setStatus(ApplicationStatus.Submitted)
                .addApplicationElement("imie i nazwisko dziecka", "Jan Kowalski")
                .addApplicationElement("PESEL dziecka", "12345678901")
                .addApplicationElement("data urodzenia dziecka", "01/01/2008")
                .addApplicationElement("numer dowodu dziecka", "ABC123456")
                .addApplicationElement("obywatelstwo dziecka", "Polska")
                .addApplicationElement("stan cywilny dziecka", "Kawaler")
                .addApplicationElement("płeć dziecka", "Chłopiec")
                .addApplicationElement("oświadczenie", "Tak")
                .addApplicationElement("członkowie rodziny za granicą", "Brak")
                .addApplicationElement("numer konta", "1234567890")
            .getResult();

            //sprawdza czy wniosek otrzymal poprawny status
            Assert.AreEqual(ApplicationStatus.Submitted, applicationBuilder.applicationStatus);
            //sprawdza czy dziecko ma ponizej 18lat
            Assert.IsTrue(DateTime.Parse(applicationBuilder.elementValue[2]) > DateTime.Now.AddYears(-18));
            //sprawdza czy PESEL ma 11 znakow
            Assert.IsTrue(applicationBuilder.elementValue[1].Length == 11);
        }
    }
}