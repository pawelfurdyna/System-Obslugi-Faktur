using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBD
{
    public class ObslugaBazy
    {
        private string connectionString;
        private OracleConnection conn;

        public ObslugaBazy()
        {
            this.connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;
            this.conn = new OracleConnection(connectionString);
        }
        public void wypelnijTextBoxZEncji(string encja, string klucz, string nazwa, TextBox[] pola, string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                using (OracleCommand cmd = new OracleCommand($"SELECT {args[i]} FROM {encja} WHERE {klucz} = '{nazwa}'", this.conn))
                {
                    conn.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string temp = rdr[args[i]].ToString();
                        pola[i].Text = temp;
                    }
                    conn.Close();
                }
            }
        }

    }
}
