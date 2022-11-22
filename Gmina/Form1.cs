using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string Password = PasswordBox.Text;
            string str = @"http://localhost:5066/User/" + Login + "/" + Password;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            Debug.WriteLine(responseString);

            this.Hide();
            HomePage homePage = new HomePage();
            //this.Show(homePage);
            homePage.Show();   
            // HomePage.Hide();
            //homePage1.Show();
        }

      
    }
}
