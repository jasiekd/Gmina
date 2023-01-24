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
    public partial class ListItem : UserControl
    {
        HomePage homePage;
       // EventsBody eventsBody;
        public ListItem(HomePage homePage)
        {
            this.homePage = homePage;
            InitializeComponent();
          
           // this.eventsBody = eventsBody;
        }
        private string _title;
        private string _description;
        private Image _picture;
        private string _longDescription;
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        public string LongDescription
        {
            get { return _longDescription; }
            set { _longDescription = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; lblDescription.Text = value; }
        }
        
        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; EventPicture.Image = value; }
        }

        private void ListItem_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void ListItem_Load(object sender, EventArgs e)
        {

        }

        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(86)))));
            
        }

        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(50)))));
        }

        private void ListItem_MouseClick(object sender, MouseEventArgs e)
        {
          //  eventsBody.CurrentListItem = this;
           // homePage.ShowSingleEvent();

        }

        private void ShowSingleEvent_Click(object sender, EventArgs e)
        {
            //singleEvent1.Show();
            homePage.ShowSingleEvent(_title, _longDescription, _picture);
        }
    }
}
