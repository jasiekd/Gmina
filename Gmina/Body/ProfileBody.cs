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
namespace Gmina.Body
{
    public partial class ProfileBody : UserControl
    {
        public ProfileBody()
        {
            InitializeComponent();
            


            namelbl.Text = "Piotr";
            surnamelbl.Text = "Nowak";
            pesellbl.Text = "12345678911";
            placelbl.Text = "Sobków";
            streetlbl.Text = "kielecka";
            homeNumberlbl.Text = "10a";
            zipCodelbl.Text = "28-305";
            phoneNumberlbl.Text = "123456789";
            emailaddreslbl.Text = "piotr.nowak@poczta.pl";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileBody_Load(object sender, EventArgs e)
        {

        }
    }
}
