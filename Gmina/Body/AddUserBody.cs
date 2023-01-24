using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GminaApi.Entity;

namespace Gmina.Body
{
    public partial class AddUserBody : UserControl
    {
        public AddUserBody()
        {
            InitializeComponent();
        }
        void clearForm()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            BirthdateTextBox.ResetText();
            EmailTextBox.Clear();
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
            PhoneNumberTextBox.Clear();
            HouseNumberTextBox.Clear();
            StreetTextBox.Clear();
            ZipCodeTextBox.Clear();
            PESELTextBox.Clear();
            CityTextBox.Clear();
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            string url = @"http://localhost:5066/api/User";
            UserEntity tempUser = new UserEntity
            {
                ID = 0,
                Name = NameTextBox.Text,
                Surname = SurnameTextBox.Text,
                BirthDate = DateTime.Parse(BirthdateTextBox.Text),
                Email = EmailTextBox.Text,
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                HouseNumber = HouseNumberTextBox.Text,
                Street = StreetTextBox.Text,
                ZipCode = ZipCodeTextBox.Text,
                Pesel = PESELTextBox.Text,
                Town = CityTextBox.Text,
                RoleId = checkBox1.Checked ? 1:2,
        };

            try
            { 
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";

                string postData = JsonConvert.SerializeObject(tempUser, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                byte[] data = Encoding.UTF8.GetBytes(postData);
                request.ContentLength = data.Length;

                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(response.GetResponseStream())) ;
                DialogResult result = MessageBox.Show("Użytkownik dodany poprawnie", "Dodawanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearForm();
            }
            catch (WebException ex)
            {
                DialogResult result = MessageBox.Show("Problem z dodanie użytkownika", "Dodawanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int status = (int)(ex.Response as HttpWebResponse)?.StatusCode;
                if (status == 404)
                {
                    //alert not found
                }
                else if (status == 500)
                {
                    //alert blad serwera
                }
                else if (status == 400)
                {
                    // alert bad request
                }
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
