using Gmina.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina.Body
{
    public partial class EventsBody : UserControl
    {
        public EventsBody()
        {
            InitializeComponent();
           
           
            populateItems();


        }
       
        public void populateItems()
        {
            int n = 50;
            ListItem[] listItems = new ListItem[n];
            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Picture = Resources.image;
                listItems[i].Title = "takkkkkkkkkkk"+i;
                listItems[i].Description = "nieeeeeeeeeeeee";
                
                if (flowLayoutPanel.Controls.Count < 0)
                    flowLayoutPanel.Controls.Clear();
                else
                    flowLayoutPanel.Controls.Add(listItems[i]);
    
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
