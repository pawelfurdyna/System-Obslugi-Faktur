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
    public partial class FormUzytkownik : Form
    {
        private string query = "";
        private bool edycja;
        private string nazwa;
        ObslugaBazy ob = new ObslugaBazy();
        string encja = "UZYTKOWNIK";
        string klucz = "ID_UZYTKOWNIKA";

        public FormUzytkownik(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            this.Load += FormUzytkownik_Load;
        }

        private void FormUzytkownik_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        ob.wypelnijTextBoxZEncji(encja, klucz, nazwa, 
                            new TextBox[] { tbIdUzytkownika, tbImie, tbNazwisko, tbRola, tbLogin, tbHaslo }, 
                            new string[] { "ID_UZYTKOWNIKA", "IMIE", "NAZWISKO", "ROLA", "LOGIN", "HASLO"});
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
                tbIdUzytkownika.Enabled = false;
                //query = $"UPDATE STAWKA_VAT SET PROCENT_VAT = '{this.tbProcentVAT.Text}' WHERE ID_VAT = '{this.tbNazwa.Text}'";
            }
            else
            {
                tbIdUzytkownika.Enabled = true;
                //query = $"INSERT INTO SYSTEM.STAWKA_VAT (ID_VAT, PROCENT_VAT) VALUES ('{this.tbNazwa.Text}', '{this.tbProcentVAT.Text}')";
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
