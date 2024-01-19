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
        ComboBox cb;
        string[] atrybuty = { "IMIE", "NAZWISKO", "LOGIN", "HASLO", "ROLA" };
        ObslugaBazy ob = new ObslugaBazy();

        public FormUzytkownik(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbImie, tbNazwisko, tbLogin, tbHaslo };
            cb = cbRola;
            this.Load += FormUzytkownik_Load;
        }

        private void FormUzytkownik_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, tb, atrybuty, cb);
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
    #region Walidacja

            if (string.IsNullOrWhiteSpace(tbImie.Text))
            {
                errorProvider1.SetError(tbImie, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbImie, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbImie, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbNazwisko.Text))
            {
                errorProvider1.SetError(tbNazwisko, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbNazwisko, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbNazwisko, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(cbRola.Text))
            {
                errorProvider1.SetError(cbRola, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.cbRola, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(cbRola, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                errorProvider1.SetError(tbLogin, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbLogin, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbLogin, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbHaslo.Text))
            {
                errorProvider1.SetError(tbHaslo, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbHaslo, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbHaslo, string.Empty);
            }

    #endregion

            if (!string.IsNullOrWhiteSpace(tbImie.Text) && !string.IsNullOrWhiteSpace(tbNazwisko.Text) && !string.IsNullOrWhiteSpace(cbRola.Text) && !string.IsNullOrWhiteSpace(tbLogin.Text) && !string.IsNullOrWhiteSpace(tbHaslo.Text))
            {
                if (edycja)
                {
                    ob.EdytujRekord(encja, klucz, nazwa, tb, atrybuty);
                    this.Close();
                }
                else
                {
                    ob.DodajRekord(encja, tb, atrybuty, cb);
                    this.Close();
                }
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbRola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
