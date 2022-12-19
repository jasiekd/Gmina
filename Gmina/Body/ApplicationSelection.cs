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
    public partial class ApplicationSelection : UserControl
    {
        CoalApplication coalApplication;
        public ApplicationSelection()
        {
            InitializeComponent();
        }
        public void setCoalApplication(CoalApplication coalApplication)
        {
            this.coalApplication = coalApplication;
        }

        private void buttonRounded2_Click(object sender, EventArgs e)
        {
            if(coalApplication != null)
            {
                coalApplication.Show();
                coalApplication.BringToFront();
            }
        }
    }
}
