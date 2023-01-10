using Gmina.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina.Body
{
    public partial class EventsBody : UserControl
    {
        //HomePage homePage;
        public ListItem CurrentListItem;
      
        public EventsBody()
        {
            CurrentListItem = new ListItem();
            CurrentListItem.Picture = Resources.image;
            CurrentListItem.Title = "lol";
            CurrentListItem.Description = "wtf";
            //this.homePage = homePage;
            InitializeComponent();

            populateItems();
            

        }
       public string wtf()
        {

            return CurrentListItem.Description;
        }
        public void populateItems()
        {
            string str = @"http://localhost:5066/api/Event";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(str);
            request.Method = "GET";
            request.Accept = "application/json";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                string json = new StreamReader(response.GetResponseStream()).ReadToEnd();

                List<EventEntity> list2 = JsonConvert.DeserializeObject<List<EventEntity>>(json);

                ListItem[] listItems = new ListItem[list2.Count];
                for (int i=0; i < listItems.Length; i++)
                {
                    listItems[i] = new ListItem();
                    listItems[i].Picture = Resources.image;
                    listItems[i].Title = list2.ElementAt(i).Title;
                    listItems[i].Description = list2.ElementAt(i).ShortDescription;

                    if (flowLayoutPanel.Controls.Count < 0)
                        flowLayoutPanel.Controls.Clear();
                    else
                        flowLayoutPanel.Controls.Add(listItems[i]);
                }
            } 
        }
        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EventsBody_Load(object sender, EventArgs e)
        {

        }
    }
}
