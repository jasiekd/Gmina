using Gmina_Api.Entity;
using GminaApi.Entity;
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
    public partial class ClerkApplications : UserControl
    {
        List<UserApplicationEntity> data;
        public ClerkApplications()
        {
            InitializeComponent();
            createTable();
        }
        public void createTable()
        {
            data = LoadData();
            ApplicationsList.Rows.Clear();
            foreach (var item in data)
            {
                ApplicationsList.Rows.Add(item.ID, item.Application.Name, item.DatePosted.ToString(), item.Status);
            }
            foreach (DataGridViewRow row in ApplicationsList.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.FromArgb(60, 78, 176);
                row.DefaultCellStyle.ForeColor = Color.FromArgb(246, 246, 246);
            }
        }
        private List<UserApplicationEntity> LoadData()
        {
            // pobranie danych o wnioskach z serwera

            string str = @"http://localhost:5066/api/UserApplication";

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
        private void ApplicationsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ApplicationsList.Columns[e.ColumnIndex].Name == "AppDecision")
            {
                
                ApplicationInfo info = new ApplicationInfo();
                foreach(var i in data )
                {
                    if(i.ID == (int)ApplicationsList.Rows[e.RowIndex].Cells[0].Value)
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
