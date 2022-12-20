using Gmina.Body;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina
{
    public partial class ApplicationInfo : Form
    {
        private static UserApplication application;
        private ClerkApplications clerkApplications;
        public ApplicationInfo()
        {
            InitializeComponent();
            
        }
        public void setClerkApplicationView(ClerkApplications clerkApplications)
        {
            this.clerkApplications = clerkApplications;
        }
        internal static UserApplication Application { get => application; set => application = value; }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < application.elementValue.Count; i++)
            {
                ApplicationsList.Rows.Add(application.elementName[i], application.elementValue[i]);
                Trace.WriteLine(application.elementName[i]);

            }
            foreach (DataGridViewRow row in ApplicationsList.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(60, 78, 176);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(246, 246, 246);
            }
        }

        private void ApplicationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void akceptButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno zatwierdzić wniosek", "Zatwierdzanie", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                if(clerkApplications!=null)
                {
                    application.applicationStstus = ApplicationStstus.Accepted;
                    //To do: zmianan statusu wniosku po stronie serwera
                    clerkApplications.createTable();
                    clerkApplications.Show();
                    clerkApplications.BringToFront();
                    this.Close();
                }

            }
            else
            {

            }
        
        }

        private void correntButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno odesłać wniosek do poprawy", "Poprawa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                application.applicationStstus = ApplicationStstus.Improvement;
                //To do: zmianan statusu wniosku po stronie serwera
                clerkApplications.createTable();
                clerkApplications.Show();
                clerkApplications.BringToFront();
                this.Close();
            }
            else
            {

            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno odrzucić wniosek", "Odrzucanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                application.applicationStstus = ApplicationStstus.Rejected;
                //To do: zmianan statusu wniosku po stronie serwera
                clerkApplications.createTable();
                clerkApplications.Show();
                clerkApplications.BringToFront();
                this.Close();
            }
            else
            {

            }
        }
    }
}
