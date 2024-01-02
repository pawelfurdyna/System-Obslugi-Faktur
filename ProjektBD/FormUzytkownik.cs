using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace ProjektBD
{
    public partial class FormUzytkownik : Form
    {
        private bool edycja;
        private string nazwa;
        string encja = "UZYTKOWNIK";
        string klucz = "ID_UZYTKOWNIKA";
        TextBox[] tb = new TextBox[] { };
        string[] atrybuty = { "ID_UZYTKOWNIKA", "IMIE", "NAZWISKO", "ROLA", "LOGIN", "HASLO" };
        ObslugaBazy ob = new ObslugaBazy();

        public FormUzytkownik(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbIdUzytkownika, tbImie, tbNazwisko, tbRola, tbLogin, tbHaslo };
            this.Load += FormUzytkownik_Load;
        }

        private void FormUzytkownik_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, tb, atrybuty);
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (edycja)
            {
                ob.EdytujRekord(encja, klucz, nazwa, tb, atrybuty);
                this.Close();
            }
            else
            {
                ob.DodajRekord(encja, tb, atrybuty);
                this.Close();
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbIdUzytkownika_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ob.SprawdzTyp(sender, e))
            {
                errorProvider1.SetError(tbIdUzytkownika, "Można wprowadzać tylko cyfry!");
                this.errorProvider1.SetIconPadding(this.tbIdUzytkownika, -20);
            }
            else
            {
                errorProvider1.SetError(tbIdUzytkownika, string.Empty);
            }
        }

        private void tbIdUzytkownika_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbIdUzytkownika, string.Empty);
        }
    }
}
