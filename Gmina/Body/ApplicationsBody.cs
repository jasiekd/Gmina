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
    public partial class ApplicationsBody : UserControl
    {
        public ApplicationsBody()
        {
            InitializeComponent();
            //String stdDetails = "{0, -10}{1,-20}{2,-20}{3,-20}{4,-20}";
            // ApplicationsList.Items.Add(String.Format(stdDetails,"ID", "Nazwa", "Data Złożenia", "Status", "Akcje"));

            //string ID = "lol";
            // ApplicationsList.Items.Add(ID);
            //ApplicationsList.Items.Add("Item ");
            //ApplicationsList.Items.Add("Item2 ");
            //ApplicationsList.Items.Add("Item3 ");
            //ApplicationsList.Items.Add("Item 4");
            var data = LoadData();
           // ApplicationsList.Clear();
            ApplicationsList.Rows.Clear();
            foreach ( var item in data)
            {
                //var row = new String[] { item.ID.ToString(), item.Name, item.Submission_Date.ToString(), item.Status, item.Action };
                //var lvi = new ListViewItem(row);
                //lvi.Tag = item;
                ApplicationsList.Rows.Add(item.ID.ToString(), item.Name, item.Submission_Date.ToString(), item.Status);
                //ApplicationsList.Add(lvi);
    
            }
        }
        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<Application> LoadData()
        {
            // pobranie danych o wnioskach z serwera
            var list = new List<Application>();
            list.Add(new Application() { ID=1,Name="wniosek jakis",Submission_Date= new DateTime(2000,12,10),Status="wyslany",Action = "cos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});
            list.Add(new Application() { ID=2,Name="dfgdfg jakis",Submission_Date= new DateTime(2040,12,10),Status="wysldfgdfany",Action = "dfgdfos"});

            return list;
        }

        private void ApplicationList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ApplicationsList.Columns[e.ColumnIndex].Name == "Edit")
            {
                Trace.WriteLine("działa Edit");
               
            }
            else if (ApplicationsList.Columns[e.ColumnIndex].Name == "Correct")
            {
                Trace.WriteLine("działa Correct");
            }
            else if (ApplicationsList.Columns[e.ColumnIndex].Name == "Cancel")
            {
                Trace.WriteLine("działa Cancel");
                
            }
        }

        private void AddApplication_Click(object sender, EventArgs e)
        {
         
        }
    }
}
