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
        public void WypelnijTextBoxZEncji(string encja, string klucz, string nazwa, TextBox[] pola, string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                using (OracleCommand cmd = new OracleCommand($"SELECT {args[i]} FROM {encja} WHERE {klucz} = '{nazwa}'", this.conn))
                {
                    this.conn.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string temp = rdr[args[i]].ToString();
                        pola[i].Text = temp;
                    }
                    this.conn.Close();
                }
            }
        }

        public void UsunRekord(string encja, string klucz, string nazwa)
        {
            DialogResult dr = MessageBox.Show($"Czy napewno chcesz usunąć \"{nazwa}\" ?",
                     "Usunąć?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    using (this.conn)
                    {
                        try
                        {
                            this.conn.Open();
                            using (OracleCommand cmd = new OracleCommand($"DELETE FROM {encja} WHERE {klucz}='{nazwa}'", this.conn))
                            {
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected != 0)
                                {
                                    if (rowsAffected == 1)
                                    {
                                        MessageBox.Show($"Poprawnie usnięto {rowsAffected} rekord!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Poprawnie usnięto {rowsAffected} rekordów!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            this.conn.Close();
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.conn.Close();
                        }
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
        public void DodajRekord(string encja, string klucz, string nazwa)
        {

        }

        public void EdytujRekord(string encja, string klucz, string nazwa)
        {

        }
    }
}

