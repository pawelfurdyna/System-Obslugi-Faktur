using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBD
{
    public partial class FormLogowanie : Form
    {
        ObslugaBazy ob = new ObslugaBazy();
        public FormLogowanie()
        {
            InitializeComponent();
            tbLogin.Focus();
        }
        
        private void btZaloguj_Click(object sender, EventArgs e)
        {
            string login, haslo,zwrot;
            login = tbLogin.Text;
            haslo = tbHaslo.Text;

            try
            {
                zwrot = ob.Select("UZYTKOWNIK", "HASLO", "LOGIN", tbLogin.Text.ToString(), true);
                if (haslo == zwrot && !String.IsNullOrEmpty(haslo))
                {
                    Form menu = new SystemObslugiFaktur();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wprowadzono niepoprawne hasło! Spróbuj ponownie!", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbLogin.Clear();
                    tbHaslo.Clear();
                    tbLogin.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił nieznany błąd!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }    
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogowanie_Load(object sender, EventArgs e)
        {
            tbLogin.Focus();
        }

        private void tbLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btZaloguj_Click(sender, e);
            }
        }

        private void tbHaslo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btZaloguj_Click(sender, e);
            }
        }
    }
}
