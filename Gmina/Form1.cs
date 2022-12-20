using Azure;
using GminaApi.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using GminaApi.Entity;
//using Newtonsoft.Json;

namespace Gmina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Login = LoginBox.Text;
            //Login = "admin.tadek1";
            string Password = PasswordBox.Text;
            //Password = "12345";
            string str = @"http://localhost:5066/api/User/" + Login + "/" + Password;
            try { 
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str);
                request.Method = "POST";
                request.Accept = "application/json";
            
                using(HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

                    UserEntity user = JsonConvert.DeserializeObject<UserEntity>(json);

                    if(user.RoleId == 2)
                    {
                        this.Hide();
                        HomePage homePage = new HomePage();
                        homePage.setUser(user);
                        homePage.Show();
                    }
                    else
                    {
                        ClerkPage clerkPage = new ClerkPage();
                        clerkPage.setUser(user);
                        clerkPage.Show();
                    }


                }
            }
            catch (WebException ex) {
                int status = (int)(ex.Response as HttpWebResponse)?.StatusCode;
                if (status == 404)
                {
                    //alert not found
                }
                else if (status == 500)
                {
                    //alert blad serwera
                }
            }            
        }     
    }
}
