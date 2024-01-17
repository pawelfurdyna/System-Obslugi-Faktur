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

        private void tbTerminPlatnosci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ob.SprawdzTyp(sender, e))
            {
                errorProvider1.SetError(tbTerminPlatnosci, "Można wprowadzać tylko cyfry!");
                this.errorProvider1.SetIconPadding(this.tbTerminPlatnosci, -20);
            }
            else
            {
                errorProvider1.SetError(tbTerminPlatnosci, string.Empty);
            }
        }

        private void tbTerminPlatnosci_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbTerminPlatnosci, string.Empty);
        }
    }
}
