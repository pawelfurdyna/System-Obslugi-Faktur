using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;



namespace ProjektBD
{
    public partial class FormStawkaVAT : Form
    {
        private bool edycja;
        private string nazwa;
        string encja = "STAWKA_VAT";
        string klucz = "ID_VAT";
        TextBox[] tb = new TextBox[] { };
        string[] atrybuty = { "ID_VAT", "PROCENT_VAT" };
        ObslugaBazy ob = new ObslugaBazy();


        public FormStawkaVAT(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbNazwa, tbProcentVAT };
            this.Load += FormStawkaVAT_Load;
        }

        private void FormStawkaVAT_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, tb , atrybuty);
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

        private void tbProcentVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ob.SprawdzTyp(sender, e);
        }
    }
}
