using Oracle.ManagedDataAccess.Client;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.NetworkInformation;
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

        #region WypelnijTextBox
        public void WypelnijTextBoxZEncji(string encja, string klucz, string nazwa, TextBox[] tb, string[] atrybuty)
        {
            for (int i = 0; i < atrybuty.Length; i++)
            {
                OracleCommand cmd = new OracleCommand($"SELECT {atrybuty[i]} FROM {encja} WHERE {klucz} = '{nazwa}'", this.conn);
                try
                {
                    this.conn.Open();
                    OracleDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        string temp = rdr[atrybuty[i]].ToString();
                        tb[i].Text = temp;
                    }
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.conn.Close();
                }
            }
        }
        #endregion

        #region WypelnijComboBox
        public void WypelnijComboBoxZEncji(string encja, ComboBox cb, string[] atrybuty)
        {
            string formattedStringAtrybuty = string.Join(", ", atrybuty);
            OracleCommand cmd = new OracleCommand($"SELECT {formattedStringAtrybuty} FROM {encja}", this.conn);
            try
            {
                this.conn.Open();
                OracleDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string temp = "";
                    for (int i = 0; i < atrybuty.Length; i++)
                    {
                        temp += rdr[atrybuty[i]].ToString();
                        if (i < atrybuty.Length - 1)
                        {
                            temp += " ";
                        }
                    }
                    cb.Items.Add(temp);
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.conn.Close();
            }
        }
        #endregion

        #region UsunRekord
        public void UsunRekord(string encja, string klucz, string nazwa)
        {
            DialogResult dr = MessageBox.Show($"Czy napewno chcesz usunąć \"{nazwa}\" ?",
                     "Usunąć?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    OracleCommand cmd = new OracleCommand($"DELETE FROM {encja} WHERE {klucz}='{nazwa}'", this.conn);
                    try
                    {
                        this.conn.Open();
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
                    catch (OracleException ex)
                    {
                        MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.conn.Close();
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
        #endregion

        #region DodajRekord
        public void DodajRekord(string encja, TextBox[] tb, string[] atrybuty)
        {
            string formattedStringAtrybuty = string.Join(", ", atrybuty);
            string formattedStringTb = "";
            for (int i = 0; i < tb.Length; i++)
            {
                formattedStringTb += tb[i].Text;
                if (i < tb.Length - 1)
                {
                    formattedStringTb += "', '";
                }
            }
            string query = $"INSERT INTO {encja} ({formattedStringAtrybuty}) VALUES ('{formattedStringTb}')";

            OracleCommand cmd = new OracleCommand(query, this.conn);
            try
            {
                this.conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show($"Poprawnie dodano {rowsAffected} rekord!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Poprawnie dodano {rowsAffected} rekordów!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.conn.Close();
            }
        }
        #endregion

        #region EdytujRekord
        public void EdytujRekord(string encja, string klucz, string nazwa, TextBox[] tb, string[] atrybuty)
        {
            string formattedString = "";
            for (int i = 0; i < tb.Length; i++)
            {
                formattedString += $"{atrybuty[i]}='{tb[i].Text}'";
                if (i < tb.Length - 1)
                {
                    formattedString += ", ";
                }
            }
            string query = $"UPDATE {encja} SET {formattedString} WHERE {klucz}='{nazwa}'";

            OracleCommand cmd = new OracleCommand(query, this.conn);
            try
            {
                this.conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 0)
                {
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show($"Poprawnie edytowano {rowsAffected} rekord!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Poprawnie edytowano {rowsAffected} rekordów!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.conn.Close();
            }
        }
        #endregion

        #region SELECT
        public string Select(string encja, string atrybut, string klucz, string wartoscSzukana, bool warunek = true)
        {
            string query = "";
            string temp = "";
            if (warunek)
            {
                query = $"SELECT {atrybut} FROM {encja} WHERE {klucz} = '{wartoscSzukana}'";
            }
            else
            {
                query = $"SELECT {atrybut} FROM {encja}";
            }

            OracleCommand cmd = new OracleCommand(query, this.conn);
            try
            {
                this.conn.Open();
                OracleDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    temp = rdr[atrybut].ToString();
                }
                return temp;
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return temp;
            }
            finally
            {
                this.conn.Close();
            }

        }
    }
    #endregion
}


