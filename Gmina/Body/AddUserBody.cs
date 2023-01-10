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
    public partial class AddUserBody : UserControl
    {
        public AddUserBody()
        {
            InitializeComponent();
        }
        void clearForm()
        {
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            BirthdateTextBox.ResetText();
            EmailTextBox.Clear();
            LoginTextBox.Clear();
            PasswordTextBox.Clear();
            PhoneNumberTextBox.Clear();
            HouseNumberTextBox.Clear();
            StreetTextBox.Clear();
            ZipCodeTextBox.Clear();
            PESELTextBox.Clear();
        }
        private void AddUser_Click(object sender, EventArgs e)
        {
            /* Sposob pobierania danych z formulaza
            string tmp;
            tmp = NameTextBox.Text;
            tmp = SurnameTextBox.Text;
            tmp = BirthdateTextBox.Text;
            tmp = EmailTextBox.Text;
            tmp = LoginTextBox.Text;
            tmp = PasswordTextBox.Text;
            tmp = PhoneNumberTextBox.Text;
            tmp = HouseNumberTextBox.Text;
            tmp = StreetTextBox.Text;
            tmp = ZipCodeTextBox.Text;
            tmp = PESELTextBox.Text;
            */

            // To do: doanie usera do bazy
            if (true)//jeżeli uda się dodać użytkownika
            {
                DialogResult result = MessageBox.Show("Użytkownik dodany poprawnie", "Dodawanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    clearForm();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Problem z dodanie użytkownika", "Dodawanie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    
                }
            }
            
        }
    }
}
