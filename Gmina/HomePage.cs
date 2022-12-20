using Gmina.Body;
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
    public partial class HomePage : Form
    {

        public HomePage()
        {

            InitializeComponent();
            menuBody.Show();
            menuBody.BringToFront();
            applicationsBody1.setSelectionScreen(applicationSelection1);
            applicationSelection1.setCoalApplication(coalApplication1);
            applicationSelection1.setPlus500Application(plus500Application1);
            coalApplication1.setMenuBody(menuBody);
            plus500Application1.setMenuBody(menuBody);
            profileBody1.setUser(user);
            profileBody1.SetUserProfileLabels();
        }

        public void ShowSingleEvent()
        {
            singleEvent2 = new SingleEvent();
            initSingleEvent();
            singleEvent2.Show();
            singleEvent2.BringToFront();
        }

        private void taxesBody_Load(object sender, EventArgs e)
        {
            taxesBody.Hide();
        }
       


        private void menuBody_Load(object sender, EventArgs e)
        {
            taxesBody.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            singleEvent2.Hide();
        }

        private void electionsBody_Load(object sender, EventArgs e)
        {
            electionsBody1.Hide();
        }
        private void applicationsBody1_Load(object sender, EventArgs e)
        {
            applicationsBody1.Hide();
        }
        private void eventsBody1_Load(object sender, EventArgs e)
        {
            //eventsBody1.Hide();
        }



        private void supportContactBody1_Load(object sender, EventArgs e)
        {
            supportContactBody1.Hide();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void MenuButton_Click(object sender, EventArgs e)
        {
            menuBody.Show();
            menuBody.BringToFront();
        }



        private void TaxesButton_Click(object sender, EventArgs e)
        {
            taxesBody.Show();
            taxesBody.BringToFront();
        }

        private void ElectionsButton_Click(object sender, EventArgs e)
        {
            electionsBody1.Show();
            electionsBody1.BringToFront();
        }

        private void ApplicationsButton_Click(object sender, EventArgs e)
        {
            applicationsBody1.Show();
            applicationsBody1.BringToFront();
        }

        private void EvenetButton_Click(object sender, EventArgs e)
        {
            eventsBody1.Show();
            eventsBody1.BringToFront();
        }

        private void SupportContactButton_Click(object sender, EventArgs e)
        {
            supportContactBody1.Show();
            supportContactBody1.BringToFront();
        }

        private void reservationButtonAction(object sender, EventArgs e)
        {

        }

        private void aboutButtonAction(object sender, EventArgs e)
        {
           // aboutCity1.Show();
           // aboutCity1.BringToFront();
        }

        private void profileButtonAction(object sender, EventArgs e)
        {
            profileBody1.Show();
            profileBody1.BringToFront();
        }

        private void settingsButtonAction(object sender, EventArgs e)
        {

        }

        private void singleEvent1_Load(object sender, EventArgs e)
        {

        }

        private void eventsBody1_Load_1(object sender, EventArgs e)
        {
            eventsBody1.Hide();
        }

        private void singleEvent2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileBody1_Load(object sender, EventArgs e)
        {
            profileBody1.Hide();
        }
    }
}
