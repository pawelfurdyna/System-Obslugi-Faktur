using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBD
{
    public class ObslugaBazy
    {
        public void wypelnijTextBoxZEncji(OracleConnection conn, string encja, string klucz, string nazwa, TextBox[] pola, string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                using (OracleCommand cmd = new OracleCommand($"SELECT {args[i]} FROM {encja} WHERE {klucz} = '{nazwa}'", conn))
                {
                    OracleDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string temp = rdr[args[i]].ToString();
                        pola[i].Text = temp;
                    }
                }
            }
        }

    }
}
