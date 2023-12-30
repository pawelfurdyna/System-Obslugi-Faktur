using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProjektBD
{
    public partial class FormNowaFaktura : Form
    {
        ObslugaBazy ob = new ObslugaBazy();
        public FormNowaFaktura()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNowaFaktura_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.USLUGA' . Możesz go przenieść lub usunąć.
            this.uSLUGATableAdapter.Fill(this.bDdataSet.USLUGA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.POZYCJA_FAKTURY' . Możesz go przenieść lub usunąć.
            this.pOZYCJA_FAKTURYTableAdapter.Fill(this.bDdataSet.POZYCJA_FAKTURY);
            cbKlient.SelectedItem = null;
            cbUzytkownik.SelectedItem = null;
            ObslugaBazy ob = new ObslugaBazy();
            ob.WypelnijComboBoxZEncji("UZYTKOWNIK",cbUzytkownik,new string[] { "ID_UZYTKOWNIKA","IMIE","NAZWISKO" });

            #region DataGrid
            // Remove the existing 'usluga' column
            dataGridView1.Columns.Remove("usluga");

            // Create a new DataGridViewComboBoxColumn
            DataGridViewComboBoxColumn uslugaColumn = new DataGridViewComboBoxColumn
            {
                Name = "usluga",
                HeaderText = "Usługa",
                DataSource = uSLUGABindingSource,
                DataPropertyName = "NAZWA", // Bind this column to the 'NAZWA' property
                DisplayMember = "NAZWA",
                ValueMember = "NAZWA",
                AutoComplete = true
            };

            // Add the new column to the DataGridView
            dataGridView1.Columns.Insert(1, uslugaColumn);





            #endregion

            string temp = ob.Select("FAKTURA", "NUMER_FAKTURY", "", "", false);
            if (int.TryParse(temp, out int number))
            {
                number++;
                tbNrFaktury.Text = number.ToString();
                tbNrFaktury.Enabled = false;
            }
            else
            {
                tbNrFaktury.Enabled = true;
            }

            tbDataWystawienia.Text = DateTime.Today.ToString("dd-MM-yyyy");
            tbDataWykonaniaUslugi.Text = DateTime.Today.ToString("dd-MM-yyyy");
            tbMiejsceWystawienia.Text = ob.Select("FIRMA", "MIEJSCOWOSC", "", "", false);
        }

        private void cbKlient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = ob.Select("KLIENT", "ID_KLIENTA", "NAZWA", cbKlient.Text);
            ob.WypelnijTextBoxZEncji("KLIENT", "ID_KLIENTA", temp, new System.Windows.Forms.TextBox[] { tbAdresKlienta, tbNipKlienta, tbTerminZaplaty }, new string[] { "ADRES", "NIP", "TERMIN_PLATNOSCI" });
        }

        private void cbSposobZaplaty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSposobZaplaty.SelectedIndex == 0)
            {
                this.lbTerminZaplaty.Visible = false;
                this.tbTerminZaplaty.Visible = false;
            }
            else
            {
                this.lbTerminZaplaty.Visible = true;
                this.tbTerminZaplaty.Visible = true;
            }
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {

        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {

        }

        private void tbNrFaktury_KeyPress(object sender, KeyPressEventArgs e)
        {
            ob.SprawdzTyp(sender, e);
        }

        private void tbTerminZaplaty_KeyPress(object sender, KeyPressEventArgs e)
        {
            ob.SprawdzTyp(sender, e);
        }

        private void tbDataWystawienia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ob.FormatowanieDaty(sender, e);
        }

        private void tbDataWystawienia_Validating(object sender, CancelEventArgs e)
        {
            ob.WalidacjaDaty(sender, e);
        }

        private void tbDataWykonaniaUslugi_KeyPress(object sender, KeyPressEventArgs e)
        {
            ob.FormatowanieDaty(sender, e);
        }

        private void tbDataWykonaniaUslugi_Validating(object sender, CancelEventArgs e)
        {
            ob.WalidacjaDaty(sender, e);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
            {
                var uslugaCell = dataGridView1.CurrentCell as DataGridViewComboBoxCell;
                var currentRowIndex = dataGridView1.CurrentCell.RowIndex;
                var jmCell = dataGridView1.Rows[currentRowIndex].Cells["jm"];
                var cenaJednostkowaCell = dataGridView1.Rows[currentRowIndex].Cells["cenaJednostkowa"];

                if (uslugaCell != null && uslugaCell.Value != null && jmCell != null && cenaJednostkowaCell != null)
                {
                    string selectedUsluga = uslugaCell.Value.ToString();

                    string jmValue = ob.Select("USLUGA", "JEDNOSTKA_MIARY", "NAZWA", selectedUsluga);
                    string cenaJednostkowaValue = ob.Select("USLUGA", "CENA_JEDNOSTKOWA", "NAZWA", selectedUsluga);
                    // Update the cells
                    jmCell.Value = jmValue;
                    cenaJednostkowaCell.Value = cenaJednostkowaValue;

                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn)
            {
                dataGridView1.BeginEdit(true);
                if (dataGridView1.EditingControl is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.DroppedDown = true;
                }
            }
        }
    }
}
