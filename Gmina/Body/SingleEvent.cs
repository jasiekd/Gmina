using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gmina.Body;
using static System.Net.WebRequestMethods;

namespace Gmina.Body
{
    public partial class SingleEvent : UserControl
    {
        //EventsBody eventsBody;

        public SingleEvent()
        {
            InitializeComponent();
            //this.eventsBody = eventsBody;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private string _title;
        private string _longDescription;
        private string _picture;
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        public string Description
        {
            get { return _longDescription; }
            set { _longDescription = value; lblDescription.Text = value; }
        }

        public string Picture
        {
            get { return _picture; }
            set { _picture = value; EventPicture.ImageLocation = value; }
        }

        private void SingleEvent_Load(object sender, EventArgs e)
        {
            //lblDescription.Text = eventsBody.wtf();
            EventPicture.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void EventPicture_Click(object sender, EventArgs e)
        {
            
        }
    }
}
