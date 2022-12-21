using Gmina_Api.Entity;
using Microsoft.VisualBasic.ApplicationServices;
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

namespace Gmina.Body
{
    public partial class Wnioski : UserControl
    {
        ApplicationSelection selection;
        public Wnioski()
        {
            InitializeComponent();
            List<UserApplicationEntity> data = LoadData();
            ApplicationsList.Rows.Clear();
            foreach (UserApplicationEntity item in data)
            {
          
                ApplicationsList.Rows.Add(item.ID, item.Application.Name, item.DatePosted.ToString(), item.Status);
            }
            foreach (DataGridViewRow row in ApplicationsList.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(60, 78, 176);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(246, 246, 246);
            }
                   
            
        }
        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<UserApplicationEntity> LoadData()
        {
            string str = @"http://localhost:5066/api/UserApplication/GetForUser/" + 1;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str);
            request.Method = "GET";
            request.Accept = "application/json";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

                List<UserApplicationEntity> list2 = JsonConvert.DeserializeObject<List<UserApplicationEntity>>(json);

                return list2;
            }
            return null;
        }

        private void ApplicationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ApplicationsList.Columns[e.ColumnIndex].Name == "Edit")
            {
                Trace.WriteLine("działa Edit"+ ApplicationsList.Rows[e.RowIndex].Cells[0].Value);
                   
               
            }
            else if (ApplicationsList.Columns[e.ColumnIndex].Name == "Correct")
            {
                Trace.WriteLine("działa Correct");
            }
            else if (ApplicationsList.Columns[e.ColumnIndex].Name == "Cancel")
            {
                Trace.WriteLine("działa Cancel");
                string message = "Czy na pewno anulować wniosek?";
                string caption = "Anulowanie wniosku";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons,MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    //To do: usówanie wniosku na serwerze

                    ApplicationsList.Rows.RemoveAt(e.RowIndex);
                }
                
            }
        }
        public void setSelectionScreen(ApplicationSelection selection)
        {
            this.selection = selection;
        }
        private void AddApplication_Click(object sender, EventArgs e)
        {
            if(selection!=null)
            {
                Trace.WriteLine("działa Cancel");
                selection.Show();
                selection.BringToFront();
            }
            
        }

        private void Wnioski_Load(object sender, EventArgs e)
        {

        }
    }
}
