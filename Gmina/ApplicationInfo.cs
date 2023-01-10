using Gmina.Body;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina
{
    public partial class ApplicationInfo : Form
    {
        private static UserApplicationEntity application;
        private ClerkApplications clerkApplications;
        public ApplicationInfo()
        {
            InitializeComponent();
            
        }
        public void setClerkApplicationView(ClerkApplications clerkApplications)
        {
            this.clerkApplications = clerkApplications;
        }
        internal static UserApplicationEntity Application { get => application; set => application = value; }

        private void ApplicationInfo_Load(object sender, EventArgs e)
        {
            string str = @"http://localhost:5066/api/UserApplicationValue/GetFor/" + application.ID;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str);
            request.Method = "GET";
            request.Accept = "application/json";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

                List<UserApplicationValueEntity> list2 = JsonConvert.DeserializeObject<List<UserApplicationValueEntity>>(json);
                foreach(var item in list2)
                {
                    ApplicationsList.Rows.Add(item.ParameterName, item.Value);
                }
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

        private void changeStatus(int id, string status)
        {
            string str = @"http://localhost:5066/api/UserApplication/ChangeStatus/" + id + "/" + status;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str);
            request.Method = "GET";
            request.Accept = "application/json";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                
            }
        }

        private void akceptButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy napewno zatwierdzić wniosek", "Zatwierdzanie", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                if(clerkApplications!=null)
                {
                    changeStatus(application.ID, ApplicationStatus.Accepted.ToString());
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

                changeStatus(application.ID, ApplicationStatus.Improvement.ToString());
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
                changeStatus(application.ID, ApplicationStatus.Rejected.ToString());
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
