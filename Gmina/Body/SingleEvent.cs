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
namespace Gmina.Body
{
    public partial class SingleEvent : UserControl
    {
        EventsBody eventsBody;

        public SingleEvent(EventsBody eventsBody)
        {
            InitializeComponent();
            this.eventsBody = eventsBody;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private string _title;
        private string _description;
        private Image _picture;
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
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

        private void SingleEvent_Load(object sender, EventArgs e)
        {
            lblDescription.Text = eventsBody.wtf();


        }
    }
}
