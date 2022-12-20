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
        public ClerkApplications()
        {
            InitializeComponent();
            List<Body.UserApplication> data = LoadData();
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
            var list = new List<Body.UserApplication>();
            list.Add(new Body.UserApplication(new List<String>(), new List<String>(), ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(new List<String>(), new List<String>(), ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));
            list.Add(new Body.UserApplication(new List<String>(), new List<String>(), ApplicationType.Plus500, DateTime.Now, ApplicationStatus.Submitted, 1, 1));



            return list;
        }
        private void ApplicationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ApplicationsList.Columns[e.ColumnIndex].Name == "Edit")
            {
                Trace.WriteLine("działa Edit" + ApplicationsList.Rows[e.RowIndex].Cells[0].Value);


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
