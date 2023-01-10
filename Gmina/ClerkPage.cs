using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina
{
    public partial class ClerkPage : Form
    {
        public ClerkPage()
        {
            InitializeComponent();
        }

        private void ClerkPage_Load(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 newLogin = new Form1();
            user = null;
            DialogResult result = MessageBox.Show("Czy napewno wylogować z systemu?", "Wylogowanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                newLogin.Show();
                this.Close();
            }
            
           
        }

        private void ApplicationsButton_Click(object sender, EventArgs e)
        {
            clerkApplications4.Show();
            clerkApplications4.BringToFront();
        }

        private void EvenetButton_Click(object sender, EventArgs e)
        {
            clerkAddEvent1.Show();
            clerkAddEvent1.BringToFront();
        }
    }
}
