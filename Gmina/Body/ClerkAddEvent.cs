using Microsoft.AspNetCore.Builder;
using Newtonsoft.Json.Serialization;
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
    public partial class ClerkAddEvent : UserControl
    {
        public ClerkAddEvent()
        {
            InitializeComponent();
        }

        private void EventImageButton_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter="jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    EventImage.ImageLocation = imageLocation;
                }

            }catch(Exception exc)
            {
                MessageBox.Show("Problem z wgraniem obrazu", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddEventButton_Click(object sender, EventArgs e)
        {
            string title = EventTitleText.Text;
            string sDesc = EventShortDescription.Text;
            string desc = EventDescription.Text;
            //Bitmap image = new Bitmap(EventImage.Image);
            //Image image = EventImage.Image;

            string url = @"http://localhost:5066/api/Event/";
            EventEntity tempEvent = new EventEntity
            {
                ID = 0,
                Title = EventTitleText.Text,
                ShortDescription = EventShortDescription.Text,
                Description = EventDescription.Text,
                DateCreated = DateTime.Now,
                ClerkId = 1,
            };

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            string postData = JsonConvert.SerializeObject(tempEvent, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            byte[] data = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream())) ;

        }
    }
}
