using Oracle.ManagedDataAccess.Client;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
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
                        cmd.ExecuteNonQuery();
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
                cmd.ExecuteNonQuery();
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
                cmd.ExecuteNonQuery();
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
        public string Select(string encja, string atrybut, string klucz, string wartoscSzukana, bool warunek = true, bool sort = false)
        {
            string query = "";
            string temp = "";
            if (warunek)
            {
                query = $"SELECT {atrybut} FROM {encja} WHERE {klucz} = '{wartoscSzukana}'";
            }
            else if (sort)
            {
                query = $"SELECT {atrybut} FROM {encja} ORDER BY {atrybut} DESC";
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
        #endregion

        #region SprawdzTyp
        public bool SprawdzTyp(object sender, KeyPressEventArgs e, bool typFloat = false)
        {
            TextBox textBox = sender as TextBox;
            if (typFloat)
            {
                // Check for non-control, non-digit, and non-decimal point characters
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                {
                    e.Handled = true;
                    return false;
                }

                // Check if the decimal point is already there in the TextBox
                if (e.KeyChar == ',' && textBox.Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                    return false;
                }

                // Allow only two numbers after the decimal point
                if (textBox.Text.Contains(',') && char.IsDigit(e.KeyChar))
                {
                    int decimalPointPosition = textBox.Text.IndexOf(',');
                    int cursorPosition = textBox.SelectionStart;

                    // Check if the cursor is after the decimal point and if there are already two digits after it
                    if (cursorPosition > decimalPointPosition && textBox.Text.Length - decimalPointPosition > 2)
                    {
                        e.Handled = true;
                        return false;
                    }
                }
            }
            else
            {
                // Check for non-control, non-digit
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region FormatowanieDaty
        public void FormatowanieDaty(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            int caretPosition = textBox.SelectionStart;
            int textLength = textBox.Text.Length;

            // Limit the total length to 10 characters (DD-MM-YYYY)
            if (!char.IsControl(e.KeyChar) && textLength >= 8 && caretPosition >= textLength)
            {
                e.Handled = true;
                return;
            }

            // Automatically insert hyphen after DD and MM
            if (char.IsDigit(e.KeyChar) && (caretPosition == 1 || caretPosition == 4) && caretPosition == textLength)
            {
                // Append the digit and a hyphen if the length allows
                textBox.Text = textBox.Text.Insert(caretPosition, e.KeyChar + "/");
                e.Handled = true;
                textBox.SelectionStart = caretPosition + 2; // Move the caret after the new hyphen
            }
        }
        #endregion

        #region WalidacjaDaty
        public void WalidacjaDaty(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            DateTime parsedDate;

            // Check if the entered date is in the correct format and is a valid date
            if (!DateTime.TryParseExact(textBox.Text, "yy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                MessageBox.Show("Zły format daty. Proszę wprowadzić datę w formacie YY/MM/DD.");
                e.Cancel = true; // Prevent focus from shifting away from the TextBox
            }
        }
        #endregion

        #region ZapisywanieFaktury
        public void ZapisywanieFaktury(Label numerFaktury, TextBox[] tb, ComboBox[] cb, DataGridView dbv)
        {
            CultureInfo culture = new CultureInfo("pl-PL");
            string query = "";
            string encjaFaktura = "FAKTURA";
            string encjaPozycjaFatury = "POZYCJA_FAKTURY";
            string[] atrybutyFaktura = { "NUMER_FAKTURY", "DATA_WYSTAWIENIA", "DATA_WYKONANIA", "UWAGI", "TERMIN_ZAPLATY", "ID_KLIENTA", "ID_UZYTKOWNIKA" };
            string[] atrybutyPozycjaFaktury = { "NUMER_POZYCJI","NUMER_FAKTURY", "ID_USLUGI", "ID_VAT", "ILOSC" };
            string fAtrybutyFaktura = string.Join(", ", atrybutyFaktura);
            string fAtrybutyPozycjaFaktury = string.Join(", ", atrybutyPozycjaFaktury);
            string fPolaFaktura = "";
            string klient = cb[0].Text;
            string uzytkownik = cb[1].Text;
            string idUzytkownika = "";
            string idKlienta = "";
            string nazwaUslugi, idPozycji, idUslugi, idVat;
            float ilosc;
            

            try
            {
#region WysłanieDoEncjiFaktura
                int spaceIndex = uzytkownik.IndexOf(' ');
                if (spaceIndex != -1)
                {
                    idUzytkownika = uzytkownik.Substring(0, spaceIndex);
                }

                fPolaFaktura += numerFaktury.Text;
                fPolaFaktura += "', '";

                for (int i = 0; i < tb.Length; i++)
                {
                    fPolaFaktura += tb[i].Text;
                    if (i < tb.Length - 1)
                    {
                        fPolaFaktura += "', '";
                    }
                }

                idKlienta = Select("KLIENT", "ID_KLIENTA", "NAZWA", klient);
                fPolaFaktura += "', '";
                fPolaFaktura += idKlienta;
                fPolaFaktura += "', '";
                fPolaFaktura += idUzytkownika;

                query = $"INSERT INTO {encjaFaktura} ({fAtrybutyFaktura}) VALUES ('{fPolaFaktura}')";

                OracleCommand cmd = new OracleCommand(query, this.conn);
                try
                {
                    this.conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (OracleException ex)
                {
                    MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.conn.Close();
                }
#endregion

#region WysyłanieDoEncjiPozycjaFaktury

                foreach (DataGridViewRow row in dbv.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        idPozycji = (row.Index + 1).ToString();
                        nazwaUslugi = (string)(row.Cells["usluga"] as DataGridViewComboBoxCell).Value;
                        idUslugi = Select("USLUGA", "ID_USLUGI", "NAZWA", nazwaUslugi);
                        idVat = (string)(row.Cells["procentVat"] as DataGridViewComboBoxCell).Value;
                        if (float.TryParse((string)(row.Cells["ilosc"].Value), NumberStyles.Any, culture, out ilosc))
                        {
                            // Konwersja się powiodła, ilosc zawiera przekonwertowaną wartość
                        }
                        else
                        {
                            ilosc = 0;
                        }
                        //ilosc = float.Parse((string)(row.Cells["ilosc"].Value), CultureInfo.InvariantCulture);
                        fPolaFaktura = "";
                        fPolaFaktura += idPozycji;
                        fPolaFaktura += "', '";
                        fPolaFaktura += numerFaktury.Text;
                        fPolaFaktura += "', '";
                        fPolaFaktura += idUslugi;
                        fPolaFaktura += "', '";
                        fPolaFaktura += idVat;
                        fPolaFaktura += "', '";
                        fPolaFaktura += ilosc;

                        query = $"INSERT INTO {encjaPozycjaFatury} ({fAtrybutyPozycjaFaktury}) VALUES ('{fPolaFaktura}')";

                        cmd = new OracleCommand(query, this.conn);
                        try
                        {
                            this.conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
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
                MessageBox.Show($"Faktura została poprawnie dodana!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
#endregion
        }
        #endregion
    }
}


