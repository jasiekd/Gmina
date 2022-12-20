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

namespace Gmina.Body
{
    public partial class ClerkApplications : UserControl
    {
        List<Body.UserApplication> data;
        public ClerkApplications()
        {
            InitializeComponent();
            createTable();
        }
        public void createTable()
        {
            data = LoadData();
            ApplicationsList.Rows.Clear();
            foreach (Body.UserApplication item in data)
            {

                ApplicationsList.Rows.Add(item.applicationID, item.applicationType, item.datedOfApplication.ToString(), item.applicationStatus);
            }
            foreach (DataGridViewRow row in ApplicationsList.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(60, 78, 176);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(246, 246, 246);
            }
        }
        private List<Body.UserApplication> LoadData()
        {
            // pobranie danych o wnioskach z serwera

            List<String> tmpNazwa = new List<String>() { "t1", "t2", "t3", "t4", "t5", "t6", "t7", "t8", "t9", "t10" };
            List<String> tmpValue = new List<String>() { "e1", "e2", "e3", "e4", "e5", "e6", "e7", "e8", "e9", "e10" };


            var list = new List<Body.UserApplication>();
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa,tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue,  ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa,tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(tmpNazwa, tmpValue, ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));


            return list;
        }
        private void ApplicationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ApplicationsList.Columns[e.ColumnIndex].Name == "AppDecision")
            {
                
                ApplicationInfo info = new ApplicationInfo();
                foreach(var i in data )
                {
                    if(i.applicationID == (int)ApplicationsList.Rows[e.RowIndex].Cells[0].Value)
                    {
                        ApplicationInfo.Application = i;
                        info.setClerkApplicationView(this);
                        info.ShowDialog();
                        break;
                    }
                }
            }
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void ApplicationsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
