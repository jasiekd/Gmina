using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmina
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void TaxesButton_Click(object sender, EventArgs e)
        {
            taxesBody.Show();
        }

        private void taxesBody_Load(object sender, EventArgs e)
        {
            taxesBody.Hide();
        }
    }
}
