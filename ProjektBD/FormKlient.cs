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
        ObslugaBazy ob = new ObslugaBazy();
        string encja = "KLIENT";
        string klucz = "ID_KLIENTA";
        TextBox[] tb = new TextBox[] { };
        string[] atrybuty = { "ID_KLIENTA", "NAZWA", "ADRES", "NIP", "NUMER_TELEFONU", "EMAIL", "TERMIN_PLATNOSCI" };

    public FormKlient(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbIdKlienta, tbNazwa, tbAdres, tbNip, tbNumerTelefonu, tbEmail, tbTerminPlatnosci };
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
    }
}
