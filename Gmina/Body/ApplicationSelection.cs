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
        Plus500Application plus500Application;
        public ApplicationSelection()
        {
            InitializeComponent();
        }
        public void setCoalApplication(CoalApplication coalApplication)
        {
            this.coalApplication = coalApplication;
        }
        public void setPlus500Application(Plus500Application plus500Application)
        {
            this.plus500Application = plus500Application;
        }

        private void buttonRounded2_Click(object sender, EventArgs e)
        {
            if(coalApplication != null)
            {
                coalApplication.Show();
                coalApplication.BringToFront();
            }
        }

        private void add500plusAppButton_Click(object sender, EventArgs e)
        {
            if (plus500Application != null)
            {
                plus500Application.Show();
                plus500Application.BringToFront();
            }
        }
    }
}
