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
    public partial class FormFirma : Form
    {
        private string nazwa;
        private bool nowy = false;
        string encja = "FIRMA";
        string klucz = "NAZWA_FIRMY";
        TextBox[] tb = new TextBox[] { };
        string[] atrybuty = { "NAZWA_FIRMY", "NIP", "ULICA", "KOD_POCZTOWY", "MIEJSCOWOSC", "KONTO_BANKOWE", "TELEFON_FIRMOWY" };
        ObslugaBazy ob = new ObslugaBazy();

        public FormFirma(bool nowy = false, string nazwa = "")
        {
            InitializeComponent();
            this.nowy = nowy;
            this.nazwa = nazwa;
            tb = new TextBox[] { tbNazwaFirmy, tbNip, tbUlica, tbKodPocztowy, tbMiejscowosc, tbKontoBankowe, tbTelefonFirmowy };
            if (!nowy)
            {
                this.btnZapisz.Location = new System.Drawing.Point(238, 231);
                this.Load += FormFirma_Load;
            }
            else
            {
                this.lbKodPocztowy.Enabled = true;
                this.lbKontoBankowe.Enabled = true;
                this.lbMiejscowosc.Enabled = true;
                this.lbNazwaFirmy.Enabled = true;
                this.lbNip.Enabled = true;
                this.lbTelefonFirmowy.Enabled = true;
                this.lbUlica.Enabled = true;
                this.tbKodPocztowy.Enabled = true;
                this.tbKontoBankowe.Enabled = true;
                this.tbMiejscowosc.Enabled = true;
                this.tbNazwaFirmy.Enabled = true;
                this.tbNip.Enabled = true;
                this.tbTelefonFirmowy.Enabled = true;
                this.tbUlica.Enabled = true;
                this.btnZapisz.Visible = true;
                this.btnEdytuj.Visible = false;
                this.btnZapisz.Location = new System.Drawing.Point(319, 229);
            }
        }

        private void FormFirma_Load(object sender, EventArgs e)
        {
            
            ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, tb, atrybuty);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.btnEdytuj.Text == "Edytuj")
            {
                this.lbKodPocztowy.Enabled = true;
                this.lbKontoBankowe.Enabled = true;
                this.lbMiejscowosc.Enabled = true;
                this.lbNazwaFirmy.Enabled = true;
                this.lbNip.Enabled = true;
                this.lbTelefonFirmowy.Enabled = true;
                this.lbUlica.Enabled = true;
                this.tbKodPocztowy.Enabled = true;
                this.tbKontoBankowe.Enabled = true;
                this.tbMiejscowosc.Enabled = true;
                this.tbNazwaFirmy.Enabled = true;
                this.tbNip.Enabled = true;
                this.tbTelefonFirmowy.Enabled = true;
                this.tbUlica.Enabled = true;
                this.btnZapisz.Visible = true;
                this.btnEdytuj.Text = "Anuluj";
            }
            else
            {
                this.lbKodPocztowy.Enabled = false;
                this.lbKontoBankowe.Enabled = false;
                this.lbMiejscowosc.Enabled = false;
                this.lbNazwaFirmy.Enabled = false;
                this.lbNip.Enabled = false;
                this.lbTelefonFirmowy.Enabled = false;
                this.lbUlica.Enabled = false;
                this.tbKodPocztowy.Enabled = false;
                this.tbKontoBankowe.Enabled = false;
                this.tbMiejscowosc.Enabled = false;
                this.tbNazwaFirmy.Enabled = false;
                this.tbNip.Enabled = false;
                this.tbTelefonFirmowy.Enabled = false;
                this.tbUlica.Enabled = false;
                this.btnZapisz.Visible = false;
                this.btnEdytuj.Text = "Edytuj";
            }
            ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, tb, atrybuty);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            #region Walidacja
            if (string.IsNullOrWhiteSpace(tbNazwaFirmy.Text))
            {
                errorProvider1.SetError(tbNazwaFirmy, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbNazwaFirmy, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbNazwaFirmy, string.Empty);
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
            if (string.IsNullOrWhiteSpace(tbTelefonFirmowy.Text))
            {
                errorProvider1.SetError(tbTelefonFirmowy, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbTelefonFirmowy, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbTelefonFirmowy, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(tbKontoBankowe.Text))
            {
                errorProvider1.SetError(tbKontoBankowe, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbKontoBankowe, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbKontoBankowe, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(tbUlica.Text))
            {
                errorProvider1.SetError(tbUlica, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbUlica, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbUlica, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(tbKodPocztowy.Text))
            {
                errorProvider1.SetError(tbKodPocztowy, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbKodPocztowy, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbKodPocztowy, string.Empty);
            }
            if (string.IsNullOrWhiteSpace(tbMiejscowosc.Text))
            {
                errorProvider1.SetError(tbMiejscowosc, "Pole nie może być puste!");
                this.errorProvider1.SetIconPadding(this.tbMiejscowosc, -20);
                this.errorProvider1.BlinkRate = 0;
            }
            else
            {
                errorProvider1.SetError(tbMiejscowosc, string.Empty);
            }
            #endregion
            if (!string.IsNullOrWhiteSpace(tbNazwaFirmy.Text) &&
                !string.IsNullOrWhiteSpace(tbNip.Text) &&
                !string.IsNullOrWhiteSpace(tbTelefonFirmowy.Text) &&
                !string.IsNullOrWhiteSpace(tbKontoBankowe.Text) &&
                !string.IsNullOrWhiteSpace(tbUlica.Text) &&
                !string.IsNullOrWhiteSpace(tbKodPocztowy.Text) &&
                !string.IsNullOrWhiteSpace(tbMiejscowosc.Text))
            {
                if (nowy)
                {
                    ob.DodajRekord(encja, tb, atrybuty);
                    this.Close();
                }
                else
                {
                    ob.EdytujRekord(encja, klucz, nazwa, tb, atrybuty);
                    btnEdit_Click(sender, e);
                }
            }
        }

        private void FormFirma_Load_1(object sender, EventArgs e)
        {

        }

        private void FormFirma_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormPomoc"] as FormPomoc) == null)
            {
                FormPomoc pomoc = new FormPomoc();
                pomoc.Show();
            }
        }
    }
}
