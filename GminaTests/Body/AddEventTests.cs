using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GminaTests.Body
{
    [TestClass()]
    public class AddEventTests
    {
        [TestMethod()]
        public void addEventTest()
        {
            EventEntity tempEvent = new EventEntity
            {
                ID = 345,
                Title = "Nowe wydarzenie",
                ShortDescription = "To opis krótki",
                Description = "To opis",
                DateCreated = DateTime.Now,
                ClerkId = 56456,
                imgURL = "http://localhost/iisstart.png",
            };

            var req = HttpWebRequest.Create(tempEvent.imgURL);
            req.Method = "HEAD";
            using (var resp = req.GetResponse())
            {
                Assert.IsTrue(resp.ContentType.ToLower(CultureInfo.InvariantCulture).StartsWith("image/"));
            }
        }
    }
}
