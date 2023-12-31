﻿using System;
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
        System.Windows.Forms.TextBox[] tb = new System.Windows.Forms.TextBox[] { };
        System.Windows.Forms.ComboBox[] cb = new System.Windows.Forms.ComboBox[] { };

        public FormNowaFaktura()
        {
            InitializeComponent();
            tb = new System.Windows.Forms.TextBox[] { tbDataWystawienia, tbDataWykonaniaUslugi, tbUwagi, tbTerminZaplaty };
            cb = new System.Windows.Forms.ComboBox[] { cbKlient, cbUzytkownik };
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNowaFaktura_Load(object sender, EventArgs e)
        {
            #region Adaptery
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.STAWKA_VAT' . Możesz go przenieść lub usunąć.
            this.sTAWKA_VATTableAdapter.Fill(this.bDdataSet.STAWKA_VAT);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.USLUGA' . Możesz go przenieść lub usunąć.
            this.uSLUGATableAdapter.Fill(this.bDdataSet.USLUGA);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
            #endregion

            cbKlient.SelectedItem = null;
            ob.WypelnijComboBoxZEncji("UZYTKOWNIK",cbUzytkownik,new string[] { "ID_UZYTKOWNIKA","IMIE","NAZWISKO" });
            cbUzytkownik.SelectedIndex = FormLogowanie.AktywnyUzytkownik();

            #region Zmiana kolumn w DataGrid
            dataGridView1.Columns.Remove("usluga");
            DataGridViewComboBoxColumn uslugaColumn = new DataGridViewComboBoxColumn
            {
                Name = "usluga",
                HeaderText = "Usługa",
                DataSource = uSLUGABindingSource,
                DataPropertyName = "NAZWA",
                DisplayMember = "NAZWA",
                ValueMember = "NAZWA",
                AutoComplete = true
            };
            dataGridView1.Columns.Insert(0, uslugaColumn);

            dataGridView1.Columns.Remove("procentVat");
            DataGridViewComboBoxColumn procentVat = new DataGridViewComboBoxColumn
            {
                Name = "procentVat",
                HeaderText = "%VAT",
                DataSource = sTAWKAVATBindingSource,
                DataPropertyName = "ID_VAT",
                DisplayMember = "ID_VAT",
                ValueMember = "ID_VAT",
                AutoComplete = true
            };
            dataGridView1.Columns.Insert(5, procentVat);
            #endregion

            #region Wpisanie kolejnego numeru faktury
            string temp = ob.Select("FAKTURA", "NUMER_FAKTURY", "", "", false, true);
            if (int.TryParse(temp, out int number))
            {
                number++;
                lbNrFakturyWartosc.Text = number.ToString();
            }
            else
            {
                lbNrFakturyWartosc.Text = "1";
            }
            #endregion

            #region Wypełnienie domyślnymi wartościami dat i miejsca
            tbDataWystawienia.Text = DateTime.Today.ToString("yy-MM-dd").Replace("-","/");
            tbDataWykonaniaUslugi.Text = DateTime.Today.ToString("yy-MM-dd").Replace("-", "/");
            tbMiejsceWystawienia.Text = ob.Select("FIRMA", "MIEJSCOWOSC", "", "", false);
            #endregion
        }

        private void cbKlient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = ob.Select("KLIENT", "ID_KLIENTA", "NAZWA", cbKlient.Text);
            ob.WypelnijTextBoxZEncji("KLIENT", "ID_KLIENTA", temp, new System.Windows.Forms.TextBox[] { tbTerminZaplaty }, new string[] { "TERMIN_PLATNOSCI" });
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
            if (cbSposobZaplaty.SelectedIndex == 0)
            {
                tbTerminZaplaty.Text = "0";
            }
            ob.ZapisywanieFaktury(lbNrFakturyWartosc, tb, cb, dataGridView1);
            this.Close();
            //pobierz tb nr faktury wyslij do encji
            //pobierz tb data wystawienia wyslij do encji
            //jesli sposob zaplaty przelew to pobierz tb termin zaplaty i dodaj do aktualnej daty wyslij do encji  jesli nie to pobierz dzisiejsza date i wyslij do encji
            //z cb klient pobierz nazwe klienta odpytaj baze o klucz i wyslij do encji
            //z cb sporzadzil pobierz id uzytkownika i wyslij do encji
            //odpytaj baze o nazwe firmy ???
            //pobierz tb uwagi i wyslij do encji

            //po wyslaniu do encji faktura

            //jako id pozycji uzywaj kolejnych liczb od 1 do ...
            //pobierz tb nr faktury wyslij do encji
            //z biezacego row i columny usluga pobierz id uslugi
            //z biezacego row i columny %vat pobierz id vat
            //z biezacego row i columny pobierz ilosc
            // wartosc netto
            // wartosc vat
        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Zdarzenia do sprawdzania typów pól numerycznych
        private void tbNrFaktury_KeyPress(object sender, KeyPressEventArgs e)
        {
            ob.SprawdzTyp(sender, e);
        }

        private void tbTerminZaplaty_KeyPress(object sender, KeyPressEventArgs e)
        {
            ob.SprawdzTyp(sender, e);
        }
        #endregion

        #region Zdarzenia do pól dat
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
        #endregion

        #region Zdarzenia do obsługi DataGridView
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["usluga"]?.Index)
                {
                    var uslugaCell = dataGridView1.Rows[e.RowIndex].Cells["usluga"] as DataGridViewComboBoxCell;
                    var jmCell = dataGridView1.Rows[e.RowIndex].Cells["jm"];
                    var cenaJednostkowaCell = dataGridView1.Rows[e.RowIndex].Cells["cenaJednostkowa"];

                    if (uslugaCell != null && uslugaCell.Value != null && jmCell != null && cenaJednostkowaCell != null)
                    {
                        string selectedUsluga = uslugaCell.Value.ToString();

                        string jmValue = ob.Select("USLUGA", "JEDNOSTKA_MIARY", "NAZWA", selectedUsluga);
                        string cenaJednostkowaValue = ob.Select("USLUGA", "CENA_JEDNOSTKOWA", "NAZWA", selectedUsluga);

                        jmCell.Value = jmValue;
                        cenaJednostkowaCell.Value = cenaJednostkowaValue;
                        WyswietlSumy();
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns["ilosc"]?.Index || e.ColumnIndex == dataGridView1.Columns["usluga"]?.Index)
                {
                    var iloscCell = dataGridView1.Rows[e.RowIndex].Cells["ilosc"];
                    var cenaJednostkowaCell = dataGridView1.Rows[e.RowIndex].Cells["cenaJednostkowa"];
                    var resultCell = dataGridView1.Rows[e.RowIndex].Cells["wartoscNetto"];
                    if (iloscCell != null && cenaJednostkowaCell != null)
                    {
                        float.TryParse(iloscCell.Value?.ToString(), out float iloscValue);
                        float.TryParse(cenaJednostkowaCell.Value?.ToString(), out float cenaJednostkowaValue);
                        float result = iloscValue * cenaJednostkowaValue;
                        resultCell.Value = result;
                        WyswietlSumy();
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns["procentVat"]?.Index || e.ColumnIndex == dataGridView1.Columns["usluga"]?.Index || e.ColumnIndex == dataGridView1.Columns["ilosc"]?.Index)
                {
                    var procentVatCell = dataGridView1.Rows[e.RowIndex].Cells["procentVat"] as DataGridViewComboBoxCell;
                    if (procentVatCell != null && procentVatCell.Value != null && !string.IsNullOrEmpty(procentVatCell.Value.ToString()))
                    {
                        int procentVatCellValue = int.Parse(ob.Select("STAWKA_VAT", "PROCENT_VAT", "ID_VAT", procentVatCell.Value.ToString()));
                        var wartoscNettoCell = dataGridView1.Rows[e.RowIndex].Cells["wartoscNetto"];
                        var wartoscVatCell = dataGridView1.Rows[e.RowIndex].Cells["wartoscVat"];
                        var wartoscBruttoCell = dataGridView1.Rows[e.RowIndex].Cells["wartoscBrutto"];

                        if (wartoscNettoCell != null && wartoscVatCell != null)
                        {
                            float.TryParse(wartoscNettoCell.Value?.ToString(), out float wartoscNettoValue);
                            float wartoscVat = wartoscNettoValue * procentVatCellValue / 100;
                            wartoscVatCell.Value = wartoscVat;
                            wartoscBruttoCell.Value = wartoscNettoValue + wartoscVat;
                            WyswietlSumy();
                        }
                    }
                }
            }
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                // Get the current cell and its column index
                DataGridViewCell currentCell = dataGridView1.CurrentCell;
                int columnIndex = currentCell.ColumnIndex;

                // Check if the current cell belongs to 'usluga' or 'procentVat' column
                if (dataGridView1.Columns["usluga"] != null && columnIndex == dataGridView1.Columns["usluga"].Index ||
                    dataGridView1.Columns["procentVat"] != null && columnIndex == dataGridView1.Columns["procentVat"].Index)
                {
                    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    dataGridView1.EndEdit(); // This may not be necessary, as CommitEdit often suffices
                }
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

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["ilosc"].Value = "0";
            e.Row.Cells["cenaJednostkowa"].Value = "0";
        }

        private void WyswietlSumy()
        {
            float sumaWartoscNetto = 0f;
            float sumaWartoscVat = 0f;
            float sumaWartoscBrutto = 0f;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["wartoscNetto"].Value != null &&
                    float.TryParse(row.Cells["wartoscNetto"].Value.ToString(), out float nettoValue))
                {
                    sumaWartoscNetto += nettoValue;
                }

                if (row.Cells["wartoscVat"].Value != null &&
                    float.TryParse(row.Cells["wartoscVat"].Value.ToString(), out float vatValue))
                {
                    sumaWartoscVat += vatValue;
                }

                if (row.Cells["wartoscBrutto"].Value != null &&
                    float.TryParse(row.Cells["wartoscBrutto"].Value.ToString(), out float bruttoValue))
                {
                    sumaWartoscBrutto += bruttoValue;
                }
            }

            // Display the sums in the TextBox controls
            lbSumaNettoWartosc.Text = sumaWartoscNetto.ToString();
            lbSumaVatWartosc.Text = sumaWartoscVat.ToString();
            lbSumaBruttoWartosc.Text = sumaWartoscBrutto.ToString();
        }
        #endregion
    }
}
