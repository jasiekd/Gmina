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
    public partial class ElectionPage : Form
    {
        private int electionID;
        public ElectionPage()
        {
            InitializeComponent();
        }

        private void ElectionPage_Load(object sender, EventArgs e)
        {
            CandidatesList.Rows.Clear();
            CandidatesList.Rows.Add(1, "t", "t", DateTime.Now);
            CandidatesList.Rows.Add(1, "a", "a", DateTime.Now);
        }
        public void Election(int electionID)
        {
            this.electionID = electionID;
        }
        private void CandidatesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CandidatesList.Columns[e.ColumnIndex].Name == "vote")
            {

                string caption = "Wybór kandydata";
                string message = "Zagłosowano z powodzeniem";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);

                // pobierz wiersz, w którym znajduje się przycisk
                DataGridViewRow row = CandidatesList.Rows[e.RowIndex];

                // wyłącz przycisk
                row.Cells[3].Value = "Wyłączony";
            }
        }
    }
}
