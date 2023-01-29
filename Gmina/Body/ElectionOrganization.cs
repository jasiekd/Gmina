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
    public partial class ElectionOrganization : UserControl
    {
        public ElectionOrganization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addElementText.Text == "")
                return;
            
            Panel panel = new Panel();
            if(listOption.Count==0)
            {
                panel.Location = new Point(0,0);
            }
            else
            {
                panel.Location = new Point(
                    0,
                    listOption[listOption.Count - 1].Location.Y+50 
               );  
            }

            if (listOption.Count % 2 == 0)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(95)))), ((int)(((byte)(207)))));
            }
            else
            {
                panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(90)))), ((int)(((byte)(245)))));
            }
            panel.Size = new System.Drawing.Size(422, 50);


            ButtonRounded tmpBtn = new ButtonRounded();
            tmpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(64)))), ((int)(((byte)(148)))));
            tmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tmpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            tmpBtn.Location = new System.Drawing.Point(350, 15);
            tmpBtn.Name = "VoteButton" + listOption.Count;
            tmpBtn.Size = new System.Drawing.Size(60, 25);
            tmpBtn.Text = "Usuń";
            int parametr = listOption.Count; //jakies cos
            tmpBtn.Click += new System.EventHandler((sender, args) => deleteElement(sender, args, parametr));
            //this.optionButtonList.Add(tmp);


            Label tmpLabel = new Label();
            tmpLabel = new Label();
            tmpLabel.AutoSize = true;
            tmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tmpLabel.ForeColor = System.Drawing.Color.White;
            tmpLabel.Location = new System.Drawing.Point(10, 15);
            tmpLabel.Name = "Votelabel" + listOption.Count;
            tmpLabel.Size = new System.Drawing.Size(191, 37);
            tmpLabel.Text = addElementText.Text; //To do: załadowanie z bazy opisu

            listOption.Add(panel);
            panel.Controls.Add(tmpLabel);
            panel.Controls.Add(tmpBtn);
            //listPanel.Controls.Add(tmpBtn);
            listPanel.Controls.Add(panel);


            listOptionString.Add(addElementText.Text);
            addElementText.Text = "";
        }

        void deleteElement(object sender, EventArgs e, int parametr)
        {
           
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            //electionTitle.Text;
            //electionDate.Text;
            //specialTypeRadio.Checked;
            //listOptionString;

            // To do: dodanie glosowania
        }
    }
}
