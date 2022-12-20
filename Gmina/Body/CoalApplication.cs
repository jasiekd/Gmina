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
    public partial class CoalApplication : UserControl
    {
        private List<RadioButton> radioButtonsH = new List<RadioButton>();
        private List<RadioButton> radioButtonsP = new List<RadioButton>();
        private MenuBody menuBody;
        public CoalApplication()
        {
            InitializeComponent();
            radioButtonsH.Add(HOption1);
            radioButtonsH.Add(HOption2);
            radioButtonsH.Add(HOption3);
            radioButtonsH.Add(HOption4);
            radioButtonsH.Add(HOption5);
            radioButtonsH.Add(HOption6);
            radioButtonsH.Add(HOption7);
            radioButtonsH.Add(HOption8);

            radioButtonsP.Add(POption1);
            radioButtonsP.Add(POption2);
            radioButtonsP.Add(POption3);
        }

        private void CoalApplication_Load(object sender, EventArgs e)
        {

        }
        public void setMenuBody(MenuBody menu)
        {
            this.menuBody = menu;
        }
        private void sendCoalApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno wysłać wniosek?", "Składanie wniosku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                UserApplication newApplication = new ApplicationBuilder()
                    .setApplicationID(1)
                    .setUserID(1)
                    .setDatedOfApplication(DateTime.Now)
                    .setApplicationType(ApplicationType.Coal)
                    .setStatus(ApplicationStatus.Submitted)
                    .addApplicationElement("numer konta",accountNumber.Text.ToString())
                    .addApplicationElement("imię i nazwisko właściciela rachunku",ownerName.Text.ToString())
                    .addApplicationElement("liczba mieszkańców",inhabitantCounter.Text.ToString())
                    .addApplicationElement("źródło ogrzewania",radioButtonsH.FirstOrDefault(r=>r.Checked).Text)
                    .addApplicationElement("położenie gospodarstwa domowego",radioButtonsP.FirstOrDefault(r=>r.Checked).Text)
                    .getResult();
                Trace.WriteLine(newApplication.ToString());
                //To do: wysłanie wniosku(obiekt newApplication) na serwer
                //To do: uzupelnianie wniosku rzeczywisty id wniosku i id urzytkownika
                MessageBox.Show("Wniosek wysłany poprawnie", "Składanie wniosku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(menuBody!=null)
                {
                    menuBody.Show();
                    menuBody.BringToFront();
                }

            }
        }
    }
}
