using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBD
{
    public partial class FormLogowanie : Form
    {
        static ObslugaBazy ob = new ObslugaBazy();
        internal static string obecnyUzytkownik = "";
        internal static string login = "";
        internal static string idPobrane = "";
        internal static int idUzytkownika;
        
        public FormLogowanie()
        {
            InitializeComponent();
            tbLogin.Focus();
        }

        private void btZaloguj_Click(object sender, EventArgs e)
        {
            string  haslo,zwrot;
            login = tbLogin.Text;
            haslo = tbHaslo.Text;

            try
            {
                zwrot = ob.Select("UZYTKOWNIK", "HASLO", "LOGIN", tbLogin.Text.ToString(), true);
                if (haslo == zwrot && !String.IsNullOrEmpty(haslo))
                {
                    obecnyUzytkownik = ob.Select("UZYTKOWNIK", "IMIE", "LOGIN", tbLogin.Text.ToString(), true);
                    obecnyUzytkownik += " ";
                    obecnyUzytkownik += ob.Select("UZYTKOWNIK", "NAZWISKO", "LOGIN", tbLogin.Text.ToString(), true);
                    Form menu = new SystemObslugiFaktur();
                    this.Hide();
                    menu.Show();
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
        public static int AktywnyUzytkownik()
        {
            idPobrane = ob.Select("UZYTKOWNIK", "ID_UZYTKOWNIKA", "LOGIN", login, true);
            Int32.TryParse(idPobrane, out idUzytkownika);
            return (idUzytkownika - 1);
        }
        public string RolaUzytkownika()
        {
            idPobrane = ob.Select("UZYTKOWNIK", "ROLA", "LOGIN", login, true);
            return idPobrane.ToString();
        }
        private void btAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormLogowanie_Load(object sender, EventArgs e)
        {
            tbLogin.Focus();
        }
    }
}
