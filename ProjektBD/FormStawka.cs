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
        public FormStawkaVAT()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string nazwa = this.tbNazwa.Text;
            string procentVat = this.tbProcentVAT.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;

            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO SYSTEM.STAWKA_VAT (ID_VAT, PROCENT_VAT) VALUES (:nazwa, :procentVat)", conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("nazwa", nazwa));
                        cmd.Parameters.Add(new OracleParameter("procentVat", procentVat));

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (OracleException ex)
                {
                    // Handle exception
                    // For example, you can log the exception or show a message to the user
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
