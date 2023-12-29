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
        private string query = "";
        private bool edycja;
        private string nazwa;
        ObslugaBazy ob = new ObslugaBazy();
        string encja = "KLIENT";
        string klucz = "ID_KLIENTA";
        public FormKlient(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            this.Load += FormKlient_Load;
        }

        private void FormKlient_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        ob.wypelnijTextBoxZEncji(conn, encja, klucz, nazwa, 
                            new TextBox[] { tbIdKlienta, tbNazwa, tbAdres, tbNip, tbNumerTelefonu, tbEmail, tbTerminPlatnosci }, 
                            new string[] { "ID_KLIENTA", "NAZWA", "ADRES", "NIP", "NUMER_TELEFONU", "EMAIL", "TERMIN_PLATNOSCI"});
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

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            if (edycja)
            {
                tbNazwa.Enabled = false;
                //query = $"UPDATE STAWKA_VAT SET PROCENT_VAT = '{this.tbNazwa.Text}' WHERE ID_VAT = '{this.tbIdKlienta.Text}'";
            }
            else
            {
                tbNazwa.Enabled = true;
                //query = $"INSERT INTO SYSTEM.STAWKA_VAT (ID_VAT, PROCENT_VAT) VALUES ('{this.tbIdKlienta.Text}', '{this.tbNazwa.Text}')";
            }

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

            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
