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
            profileBody1.setUser(currentUser);
            //profileBody1.SetUserProfileLabels();
        }

        private void ClerkPage_Load(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Form1 newLogin = new Form1();
            currentUser = null;
            DialogResult result = MessageBox.Show("Czy napewno wylogować z systemu?", "Wylogowanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                newLogin.Show();
                this.Close();
            }
            
           
        }

        private void ApplicationsButton_Click(object sender, EventArgs e)
        {
            clerkApplications5.Show();
            clerkApplications5.BringToFront();
        }

        private void EvenetButton_Click(object sender, EventArgs e)
        {
            clerkAddEvent1.Show();
            clerkAddEvent1.BringToFront();
        }

        private void addUserBody1_Load(object sender, EventArgs e)
        {
            addUserBody1.Hide();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            addUserBody1.Show();
            addUserBody1.BringToFront();    
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            menuBody1.Show();
            menuBody1.BringToFront();
        }

       

        private void menuBody1_Load(object sender, EventArgs e)
        {
            menuBody1.Hide();
        }

        private void profileBody1_Load(object sender, EventArgs e)
        {
            
            profileBody1.Hide();
            
        }

        private void profile2_Click_1(object sender, EventArgs e)
        {
            
            profileBody1.Show();
            profileBody1.BringToFront();
        }
    }
}
