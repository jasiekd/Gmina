using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GminaApi;
using GminaApi.Controllers;
using Gmina_Api;
using GminaApi.Entity;

namespace Gmina.Body
{
    public partial class ProfileBody : UserControl
    {
        private UserEntity user;
        public void setUser(UserEntity user)
        {
            this.user = user;

        }

        public ProfileBody()
        {

            InitializeComponent();
        }
        public void SetUserProfileLabels()
        {
            if(user!=null)
            {
                namelbl.Text = user.Name;
                surnamelbl.Text = user.Surname;
                pesellbl.Text = user.Pesel;
                placelbl.Text = user.Town;
                streetlbl.Text = user.Street;
                homeNumberlbl.Text = user.HouseNumber;
                zipCodelbl.Text = user.ZipCode;
                phoneNumberlbl.Text = user.PhoneNumber;
                emailaddreslbl.Text = user.Email;
                birthdatelbl.Text = user.BirthDate.ToString();
                dateAddedlbl.Text = user.DateAdded.ToString();
            }
            
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileBody_Load(object sender, EventArgs e)
        {

        }
    }
}
