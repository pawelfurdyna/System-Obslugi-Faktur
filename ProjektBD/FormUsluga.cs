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
    public partial class FormUsluga : Form
    {
        private bool edycja;
        private string nazwa;
        string encja = "USLUGA";
        string klucz = "ID_USLUGI";
        TextBox[] tb = new TextBox[] { };
        string[] atrybuty = { "ID_USLUGI", "NAZWA", "CENA_JEDNOSTKOWA", "JEDNOSTKA_MIARY" };
        ObslugaBazy ob = new ObslugaBazy();

        public FormUsluga(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbIdUslugi, tbNazwa, tbCenaJednostkowa, tbJednostkaMiary };
            this.Load += FormUsluga_Load;
        }

        private void FormUsluga_Load(object sender, EventArgs e)
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

        private void tbCenaJednostkowa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ob.SprawdzTyp(sender, e,true))
            {
                errorProvider1.SetError(tbCenaJednostkowa, "Wprowadz wartość z użyciem cyfr i przecinka jako speratatora dziesiętnego!");
                this.errorProvider1.SetIconPadding(this.tbCenaJednostkowa, -20);
            }
            else
            {
                errorProvider1.SetError(tbCenaJednostkowa, string.Empty);
            }
        }

        private void tbIdUslugi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ob.SprawdzTyp(sender, e))
            {
                errorProvider1.SetError(tbIdUslugi, "Można wprowadzać tylko cyfry!");
                this.errorProvider1.SetIconPadding(this.tbIdUslugi, -20);
            }
            else
            {
                errorProvider1.SetError(tbIdUslugi, string.Empty);
            }
        }

        private void tbIdUslugi_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbIdUslugi, string.Empty);
        }

        private void tbCenaJednostkowa_Leave(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbCenaJednostkowa, string.Empty);
        }
    }
}
