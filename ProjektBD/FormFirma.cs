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
        private string query = "";
        private bool edycja;
        private string nazwa;
        ObslugaBazy ob = new ObslugaBazy();
        string encja = "FIRMA";
        string klucz = "NAZWA_FIRMY";

        public FormFirma(bool edycja = true, string nazwa = "Serwis Komputerowy PCPROM")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            this.Load += FormFirma_Load;
        }

        private void FormFirma_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        ob.WypelnijTextBoxZEncji(encja, klucz, nazwa, 
                            new TextBox[] { tbNazwaFirmy, tbNip, tbUlica, tbKodPocztowy, tbMiejscowosc, tbKontoBankowe, tbTelefonFirmowy}, 
                            new string[] { "NAZWA_FIRMY", "NIP", "ULICA", "KOD_POCZTOWY", "MIEJSCOWOSC", "KONTO_BANKOWE", "TELEFON_FIRMOWY"});
                        conn.Close();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        conn.Close();
                    }
                }
            }

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
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            //query = $"UPDATE STAWKA_VAT SET PROCENT_VAT = '{this.tbProcentVAT.Text}' WHERE ID_VAT = '{this.tbNazwa.Text}'";

            string connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected != 0)
                        {
                            if (rowsAffected == 1)
                            {
                                MessageBox.Show($"Poprawnie zapisano {rowsAffected} rekord!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"Poprawnie zapisano {rowsAffected} rekordów!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                        conn.Close();
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conn.Close();
                }
            }
        }
    }
}
