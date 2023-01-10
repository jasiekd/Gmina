using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            createOptionList();
        }
        private void doVote(object sender, EventArgs e)
        {
            ButtonRounded buttonSender = (ButtonRounded)sender;
            Debug.WriteLine("constructor fired"+buttonSender.TabIndex);// odczyt przekazanego parametru

            //To do: wysłanie oddanego głosu na serwer

            DialogResult result = MessageBox.Show("Czy jesteś pewny/pewna swojego wyboru?", "Głosowanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void createOptionList()
        {
            //To do: należy odczytać z serwera odpowiednie informacje o głosowaniu i według wskazówek załadować je w pętli do wyświetlenia 
            ButtonRounded tmp;
            Label tmpLabel;
            Panel tmpPanel;
            this.optionButtonList = new List<ButtonRounded>();
            this.optionLabelList = new List<Label>();
            for (int i=0;i<30;i++)
            {
                tmp = new ButtonRounded();
                tmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
                tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                tmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
                tmp.Location = new System.Drawing.Point(500,0);
                tmp.Name = "VoteButton"+i;
                tmp.Size = new System.Drawing.Size(219, 50);
                tmp.Text = "Zagłosuj"+i;
                tmp.TabIndex = i; //To do: w tabindex można przekazać liczbe do funkcji doVote np jakieś id do czegoś na serwerze
                tmp.Click += new System.EventHandler(this.doVote);
                this.optionButtonList.Add(tmp);

                tmpLabel = new Label();
                tmpLabel.AutoSize = true;
                tmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                tmpLabel.ForeColor = System.Drawing.Color.White;
                tmpLabel.Location = new System.Drawing.Point(0, 0);
                tmpLabel.Name = "Votelabel"+i;
                tmpLabel.Size = new System.Drawing.Size(191, 37);
                tmpLabel.Text = "To do: Opis opcji glosowania pobranej z bazy z bazy"+i; //To do: załadowanie z bazy opisu


                this.optionLabelList.Add(tmpLabel);
                tmpPanel=new Panel();
                if (i % 2 == 0)
                {
                    tmpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
                }
                else{
                    tmpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(245)))));
                }
                
                tmpPanel.Location = new System.Drawing.Point(0, 50 * i);
                tmpPanel.Name = "VotePanel"+i;
                tmpPanel.Size = new System.Drawing.Size(860, 50);
                tmpPanel.Controls.Add(tmp);
                tmpPanel.Controls.Add(tmpLabel);

                this.panel1.Controls.Add(tmpPanel);
            }

           
            
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
