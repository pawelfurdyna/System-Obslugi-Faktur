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

namespace ProjektBD
{
    public partial class FormKlient : Form
    {
        private bool edycja;
        private string nazwa;
        string encja = "KLIENT";
        string klucz = "ID_KLIENTA";
        TextBox[] tb = new TextBox[] { };
        string[] atrybuty = { "NAZWA", "ADRES", "NIP", "NUMER_TELEFONU", "EMAIL", "TERMIN_PLATNOSCI" };
        ObslugaBazy ob = new ObslugaBazy();

        public FormKlient(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbNazwa, tbAdres, tbNip, tbNumerTelefonu, tbEmail, tbTerminPlatnosci };
            this.Load += FormKlient_Load;
        }

        private void FormKlient_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, tb, atrybuty);
                tbNazwa.Enabled = false;
            }
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            #region Walidacja
            if (string.IsNullOrWhiteSpace(tbNazwa.Text))
            {
                errorProvider1.SetError(tbNazwa, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbNazwa, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbNazwa, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbAdres.Text))
            {
                errorProvider1.SetError(tbAdres, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbAdres, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbAdres, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbNip.Text))
            {
                errorProvider1.SetError(tbNip, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbNip, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbNip, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbNumerTelefonu.Text))
            {
                errorProvider1.SetError(tbNumerTelefonu, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbNumerTelefonu, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbNumerTelefonu, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                errorProvider1.SetError(tbEmail, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbEmail, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbEmail, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbTerminPlatnosci.Text))
            {
                errorProvider1.SetError(tbTerminPlatnosci, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbTerminPlatnosci, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbTerminPlatnosci, string.Empty);
            }
            #endregion
            if (!string.IsNullOrWhiteSpace(tbNazwa.Text) &&
                !string.IsNullOrWhiteSpace(tbAdres.Text) &&
                !string.IsNullOrWhiteSpace(tbNip.Text) &&
                !string.IsNullOrWhiteSpace(tbNumerTelefonu.Text) &&
                !string.IsNullOrWhiteSpace(tbEmail.Text) &&
                !string.IsNullOrWhiteSpace(tbTerminPlatnosci.Text))
            {
                if (edycja)
                {
                    ob.EdytujRekord(encja, klucz, nazwa, tb, atrybuty);
                    this.Close();
                }
                else
                {
                    if (ob.CzyNazwaJestWBazie(encja, "NAZWA", tbNazwa.Text))
                    {
                        MessageBox.Show("Proszę zmienić nazwę klienta");
                    }
                    else
                    {
                        ob.DodajRekord(encja, tb, atrybuty);
                        this.Close();
                    }
                }
            }    
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTerminPlatnosci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ob.SprawdzTyp(sender, e))
            {
                errorProvider1.SetError(tbTerminPlatnosci, string.Empty);
                errorProvider2.SetError(tbTerminPlatnosci, "Można wprowadzać tylko cyfry!");
                errorProvider2.Icon = new IconEx(IconEx.SystemIcons.Warning, SystemInformation.SmallIconSize).Icon;
                this.errorProvider2.SetIconPadding(this.tbTerminPlatnosci, -20);
            }
            else
            {
                errorProvider2.SetError(tbTerminPlatnosci, string.Empty);
            }
        }

        private void tbTerminPlatnosci_Leave(object sender, EventArgs e)
        {
            errorProvider2.SetError(tbTerminPlatnosci, string.Empty);
        }
    }
}
