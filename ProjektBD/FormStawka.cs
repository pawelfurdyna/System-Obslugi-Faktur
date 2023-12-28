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
        private string query = "";
        private bool edycja;
        private string nazwa;

        public FormStawkaVAT(bool edycja = false, string nazwa = "")
        {
            InitializeComponent();
            this.edycja = edycja;
            this.nazwa = nazwa;
            this.Load += FormStawkaVAT_Load;
        }

        private void FormStawkaVAT_Load(object sender, EventArgs e)
        {
            if (edycja)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;

                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (OracleCommand cmd = new OracleCommand("SELECT PROCENT_VAT FROM STAWKA_VAT WHERE ID_VAT = :nazwa", conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("nazwa", nazwa));
                            OracleDataReader rdr = cmd.ExecuteReader();
                            if (rdr.Read())
                            {
                                string procent_vat = rdr["PROCENT_VAT"].ToString();
                                tbProcentVAT.Text = procent_vat;
                            }
                        }
                        using (OracleCommand cmd = new OracleCommand("SELECT ID_VAT FROM STAWKA_VAT WHERE ID_VAT = :nazwa", conn))
                        {
                            cmd.Parameters.Add(new OracleParameter("nazwa", nazwa));
                            OracleDataReader rdr = cmd.ExecuteReader();
                            if (rdr.Read())
                            {
                                string id_vat = rdr["ID_VAT"].ToString();
                                tbNazwa.Text = id_vat;
                            }
                        }

                        conn.Close();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string nazwa = this.tbNazwa.Text;
            string procentVat = this.tbProcentVAT.Text;

            if (edycja)
            {
                tbNazwa.Enabled = false;
                query = $"UPDATE STAWKA_VAT SET PROCENT_VAT = '{procentVat}' WHERE ID_VAT = '{nazwa}'";
            }
            else
            {
                tbNazwa.Enabled = true;
                query = $"INSERT INTO SYSTEM.STAWKA_VAT (ID_VAT, PROCENT_VAT) VALUES ('{nazwa}', '{procentVat}')";
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
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No rows updated. Check if the row exists and the value of 'nazwa' is correct.");
                        }
                        else
                        {
                            MessageBox.Show($"{rowsAffected} row(s) updated.");
                        }
                    }

                    conn.Close();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show(ex.Message);
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
