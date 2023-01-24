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
        public HomePage homePage;
        public ListItem CurrentListItem;
        public EventsBody()
        {
            InitializeComponent();
        }
        public EventsBody(HomePage homePage)
        {
            this.homePage = homePage;
            CurrentListItem = new ListItem(homePage);
            CurrentListItem.Picture = "https://smaller-pictures.appspot.com/images/dreamstime_xxl_65780868_small.jpg";
            CurrentListItem.Title = "t";
            CurrentListItem.Description = "a";
            CurrentListItem.LongDescription = "k";
            
            InitializeComponent();

            populateItems();
            

        }
       
      /*  public string wtf()
        {

            return CurrentListItem.Description;
        }*/
        public void populateItems()
        {
            string str = @"http://localhost:5066/api/Event/ByDate";
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
                    listItems[i] = new ListItem(homePage);
                    listItems[i].Picture = list2.ElementAt(i).imgURL;
                    listItems[i].Title = list2.ElementAt(i).Title;
                    listItems[i].Description = list2.ElementAt(i).ShortDescription;
                    listItems[i].LongDescription = list2.ElementAt(i).Description;

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
