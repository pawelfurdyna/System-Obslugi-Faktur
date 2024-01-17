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
        string[] atrybuty = {  "NAZWA", "CENA_JEDNOSTKOWA", "JEDNOSTKA_MIARY" };
        ObslugaBazy ob = new ObslugaBazy();

        public FormUsluga(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbNazwa, tbCenaJednostkowa, tbJednostkaMiary };
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

            if (string.IsNullOrWhiteSpace(tbCenaJednostkowa.Text))
            {
                errorProvider1.SetError(tbCenaJednostkowa, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbCenaJednostkowa, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbCenaJednostkowa, string.Empty);
            }

            if (string.IsNullOrWhiteSpace(tbJednostkaMiary.Text))
            {
                errorProvider1.SetError(tbJednostkaMiary, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbJednostkaMiary, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else 
            {
                errorProvider1.SetError(tbJednostkaMiary, string.Empty);
            }
            #endregion
            if (!string.IsNullOrWhiteSpace(tbNazwa.Text) && !string.IsNullOrWhiteSpace(tbCenaJednostkowa.Text) && !string.IsNullOrWhiteSpace(tbJednostkaMiary.Text))
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
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCenaJednostkowa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ob.SprawdzTyp(sender, e,true))
            {
                errorProvider1.SetError(tbCenaJednostkowa, string.Empty);
                errorProvider2.SetError(tbCenaJednostkowa, "Wprowadz wartość z użyciem cyfr i przecinka jako speratatora dziesiętnego!");
                errorProvider2.Icon = new IconEx(IconEx.SystemIcons.Warning, SystemInformation.SmallIconSize).Icon;
                this.errorProvider2.SetIconPadding(this.tbCenaJednostkowa, -20);
            }
            else
            {
                errorProvider2.SetError(tbCenaJednostkowa, string.Empty);
                //errorProvider1.Icon = SystemIcons.Error;
            }
        }

        private void tbCenaJednostkowa_Leave(object sender, EventArgs e)
        {
            errorProvider2.SetError(tbCenaJednostkowa, string.Empty);
        }
    }
}
