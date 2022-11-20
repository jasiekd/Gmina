﻿using System;
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
        }

        private void TaxesButton_Click(object sender, EventArgs e)
        {
            taxesBody.Show();
            taxesBody.BringToFront();

        }

        private void taxesBody_Load(object sender, EventArgs e)
        {
            taxesBody.Hide();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            menuBody.Show();
            menuBody.BringToFront();
            
        }

        private void menuBody_Load(object sender, EventArgs e)
        {
            taxesBody.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void electionsBody_Load(object sender, EventArgs e)
        {
            electionsBody1.Hide();
        }

        private void ElectionsButton_Click(object sender, EventArgs e)
        {
            electionsBody1.Show();
            electionsBody1.BringToFront();
        }

        private void applicationsBody1_Load(object sender, EventArgs e)
        {
            applicationsBody1.Hide();
        }

        private void ApplicationsButton_Click(object sender, EventArgs e)
        {
            applicationsBody1.Show();
            applicationsBody1.BringToFront();
        }

        private void eventsBody1_Load(object sender, EventArgs e)
        {
            eventsBody1.Hide();
        }

        private void EvenetButton_Click(object sender, EventArgs e)
        {
            eventsBody1.Show();
            eventsBody1.BringToFront();
        }

        private void supportContactBody1_Load(object sender, EventArgs e)
        {
            supportContactBody1.Hide();
        }

        private void SupportContactButton_Click(object sender, EventArgs e)
        {
            supportContactBody1.Show();
            supportContactBody1.BringToFront();
        }
    }
}
