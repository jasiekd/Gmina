using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina.Body
{
    public partial class CoalApplication : UserControl
    {
        private List<RadioButton> radioButtonsH = new List<RadioButton>();
        private List<RadioButton> radioButtonsP = new List<RadioButton>();
        private MenuBody menuBody;
        public CoalApplication()
        {
            InitializeComponent();
            radioButtonsH.Add(HOption1);
            radioButtonsH.Add(HOption2);
            radioButtonsH.Add(HOption3);
            radioButtonsH.Add(HOption4);
            radioButtonsH.Add(HOption5);
            radioButtonsH.Add(HOption6);
            radioButtonsH.Add(HOption7);
            radioButtonsH.Add(HOption8);

            radioButtonsP.Add(POption1);
            radioButtonsP.Add(POption2);
            radioButtonsP.Add(POption3);
        }

        private void CoalApplication_Load(object sender, EventArgs e)
        {

        }
        public void setMenuBody(MenuBody menu)
        {
            this.menuBody = menu;
        }
        private void sendCoalApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno wysłać wniosek?", "Składanie wniosku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                UserApplication newApplication = new ApplicationBuilder()
                    .setApplicationID(1)
                    .setUserID(HomePage.getUser().ID)
                    .setDatedOfApplication(DateTime.Now)
                    .setApplicationType(ApplicationType.Coal)
                    .setStatus(ApplicationStatus.Submitted)
                    .addApplicationElement("numer konta",accountNumber.Text.ToString())
                    .addApplicationElement("imię i nazwisko właściciela rachunku",ownerName.Text.ToString())
                    .addApplicationElement("liczba mieszkańców",inhabitantCounter.Text.ToString())
                    .addApplicationElement("źródło ogrzewania",radioButtonsH.FirstOrDefault(r=>r.Checked).Text)
                    .addApplicationElement("położenie gospodarstwa domowego",radioButtonsP.FirstOrDefault(r=>r.Checked).Text)
                    .getResult();

                string url = @"http://localhost:5066/api/UserApplication/";

                UserApplicationEntity userApplication = new UserApplicationEntity
                {
                    ID = 0,
                    UserId = newApplication.userID,
                    DatePosted = newApplication.datedOfApplication,
                    ApplicationName = newApplication.applicationType.ToString(),
                    ClerkId = 0,
                    Status = newApplication.applicationStatus.ToString(),
                    DateModified = newApplication.datedOfApplication,
                    Description = " "
                };

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";

                string postData = JsonConvert.SerializeObject(userApplication, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                byte[] data = Encoding.UTF8.GetBytes(postData);
                request.ContentLength = data.Length;

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream())) ;

                string str = @"http://localhost:5066/api/UserApplication/LastApplication/" + newApplication.userID;

                HttpWebRequest requestm = (HttpWebRequest)WebRequest.Create(str);
                requestm.Method = "GET";
                requestm.Accept = "application/json";
                int appID = 0;
                using (HttpWebResponse responsem = (HttpWebResponse)requestm.GetResponse())
                {
                    appID = int.Parse(new StreamReader(responsem.GetResponseStream()).ReadToEnd());
                }

                for (int i = 0; i < newApplication.elementName.Count; i++)
                {
                    string url6 = @"http://localhost:5066/api/UserApplicationValue/";

                    UserApplicationValueEntity userApplicationValue = new UserApplicationValueEntity
                    {
                        ID = 0,
                        ParameterName = newApplication.elementName.ElementAt(i),
                        Value = newApplication.elementValue.ElementAt(i),
                        UserApplicationId = appID,
                    };

                    HttpWebRequest requestn = (HttpWebRequest)WebRequest.Create(url6);
                    requestn.Method = "POST";
                    requestn.ContentType = "application/json";

                    string postData2 = JsonConvert.SerializeObject(userApplicationValue, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                    byte[] data2 = Encoding.UTF8.GetBytes(postData2);
                    requestn.ContentLength = data2.Length;

                    using (Stream stream = requestn.GetRequestStream())
                    {
                        stream.Write(data2, 0, data2.Length);
                    }

                    HttpWebResponse responsen = (HttpWebResponse)requestn.GetResponse();
                    using (StreamReader reader = new StreamReader(responsen.GetResponseStream())) ;
                }
                MessageBox.Show("Wniosek wysłany poprawnie", "Składanie wniosku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(menuBody!=null)
                {
                    menuBody.Show();
                    menuBody.BringToFront();
                }

            }
        }
    }
}
