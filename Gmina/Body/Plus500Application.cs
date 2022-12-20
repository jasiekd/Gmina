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
    public partial class Plus500Application : UserControl
    {
        private List<RadioButton> radioButtonsG = new List<RadioButton>();
        private List<RadioButton> radioButtonsS = new List<RadioButton>();
        private MenuBody menuBody;

        public Plus500Application()
        {
            InitializeComponent();
            radioButtonsG.Add(GOption1);
            radioButtonsG.Add(GOption2);

            radioButtonsS.Add(SOption1);
            radioButtonsS.Add(SOption2);
        }
        public void setMenuBody(MenuBody menu)
        {
            this.menuBody = menu;
        }
        private void send500PlusApp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno wysłać wniosek?", "Składanie wniosku", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                UserApplication newApplication = new ApplicationBuilder()
                    .setApplicationID(1)
                    .setUserID(1)
                    .setDatedOfApplication(DateTime.Now)
                    .setApplicationType(ApplicationType.Plus500)
                    .setStatus(ApplicationStstus.Submitted)
                    .addApplicationElement("imie i nazwisko dziecka", childName.Text)
                    .addApplicationElement("PESEL dziecka", childPESEL.Text)
                    .addApplicationElement("data urodzenia dziecka", childDateOfBirth.Text)
                    .addApplicationElement("numer dowodu dziecka", childIDCardNumber.Text)
                    .addApplicationElement("obywatelstwo dziecka", childCitizenship.Text)
                    .addApplicationElement("stan cywilny dziecka", childMaritalStatus.Text)
                    .addApplicationElement("płeć dziecka", radioButtonsG.FirstOrDefault(r=>r.Checked).Text)
                    .addApplicationElement("oświadczenie", radioButtonsS.FirstOrDefault(r=>r.Checked).Text)
                    .addApplicationElement("członkowie rodziny za granicą", abroadFamilyData.Text)
                    .addApplicationElement("numer konta", accountNymber.Text)
                    .getResult();

                //To do: wysłanie wniosku(obiekt newApplication) na serwer
                //To do: uzupelnianie wniosku rzeczywisty id wniosku i id urzytkownika
                MessageBox.Show("Wniosek wysłany poprawnie", "Składanie wniosku", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (menuBody != null)
                {
                    menuBody.Show();
                    menuBody.BringToFront();
                }

            }
        }
    }
}
