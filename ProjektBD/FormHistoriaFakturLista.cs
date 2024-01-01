using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBD
{
    public partial class FormHistoriaFakturLista : Form
    {
        ObslugaBazy ob = new ObslugaBazy();
        public FormHistoriaFakturLista()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FormHistoriaFakturLista_Activated);
        }

        private void FormHistoriaFakturLista_Activated(object sender, EventArgs e)
        {
            // Refresh data when the form becomes active
            this.fAKTURATableAdapter.Fill(this.bDDataSetFaktura.FAKTURA);
            WczytajDane();
        }

        private void FormHistoriaFakturLista_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDDataSetFaktura.FAKTURA' . Możesz go przenieść lub usunąć.

            this.fAKTURATableAdapter.Fill(this.bDDataSetFaktura.FAKTURA);
            DataGridViewTextBoxColumn terminZaplatyColumn = new DataGridViewTextBoxColumn
            {
                Name = "terminZaplaty",
                HeaderText = "Termin zapłaty(dni)"
            };
            dataGridView1.Columns.Insert(3, terminZaplatyColumn);

            DataGridViewTextBoxColumn klientColumn = new DataGridViewTextBoxColumn
            {
                Name = "klient",
                HeaderText = "Klient"
            };
            dataGridView1.Columns.Insert(3, klientColumn);

            DataGridViewTextBoxColumn uzytkownikColumn = new DataGridViewTextBoxColumn
            {
                Name = "uzytkownik",
                HeaderText = "Sporządził"
            };
            dataGridView1.Columns.Insert(5, uzytkownikColumn);

            DataGridViewTextBoxColumn wartoscNettoColumn = new DataGridViewTextBoxColumn
            {
                Name = "wartoscNetto",
                HeaderText = "Wartość Netto"
            };
            dataGridView1.Columns.Insert(5, wartoscNettoColumn);

            DataGridViewTextBoxColumn wartoscVatColumn = new DataGridViewTextBoxColumn
            {
                Name = "wartoscVat",
                HeaderText = "Wartość VAT"
            };
            dataGridView1.Columns.Insert(6, wartoscVatColumn);

            DataGridViewTextBoxColumn wartoscBruttoColumn = new DataGridViewTextBoxColumn
            {
                Name = "wartoscBrutto",
                HeaderText = "Wartość Brutto"
            };
            dataGridView1.Columns.Insert(7, wartoscBruttoColumn);
            WczytajDane();
            dataGridView1.Columns["tERMINZAPLATYDataGridViewTextBoxColumn"].Visible = false;
            dataGridView1.Columns["iDKLIENTADataGridViewTextBoxColumn"].Visible = false;
            dataGridView1.Columns["iDUZYTKOWNIKADataGridViewTextBoxColumn"].Visible = false;
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormNowaFaktura"] as FormNowaFaktura) == null)
            {
                Form nowaFaktura = new FormNowaFaktura();
                nowaFaktura.ShowDialog();
            }
        }

        private void WczytajDane()
        {
            #region Kolumny terminZaplaty, klient, uzytkownik
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (Convert.ToInt32(row.Cells["tERMINZAPLATYDataGridViewTextBoxColumn"].Value) == 0)
                    {
                        row.Cells["terminZaplaty"].Value = "zapłacono gotówką";
                    }
                    else
                    {
                        row.Cells["terminZaplaty"].Value = row.Cells["tERMINZAPLATYDataGridViewTextBoxColumn"].Value.ToString();
                    }

                    row.Cells["klient"].Value = ob.Select("KLIENT", "NAZWA", "ID_KLIENTA", row.Cells["iDKLIENTADataGridViewTextBoxColumn"].Value.ToString());

                    string temp = "";
                    temp += ob.Select("UZYTKOWNIK", "IMIE", "ID_UZYTKOWNIKA", row.Cells["iDUZYTKOWNIKADataGridViewTextBoxColumn"].Value.ToString());
                    temp += " ";
                    temp += ob.Select("UZYTKOWNIK", "NAZWISKO", "ID_UZYTKOWNIKA", row.Cells["iDUZYTKOWNIKADataGridViewTextBoxColumn"].Value.ToString());
                    row.Cells["uzytkownik"].Value = temp;
                }
            }
            #endregion

            #region Kolumny wartoscNetto, wartoscVat, wartoscBrutto
            CultureInfo culture = new CultureInfo("pl-PL");
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string numerFaktury, idUslugi, idVat, iloscString, cenaJednostkowaString, procentVatString;
                int iloscPozycji, procentVat;
                float ilosc, cenaJednostkowa;
                float wartoscNetto, wartoscVat, wartoscBrutto = 0;
                float wartoscNettoSuma = 0;
                float wartoscVatSuma = 0;
                float wartoscBruttoSuma = 0;
                if (!row.IsNewRow)
                {
                    numerFaktury = row.Cells["nUMERFAKTURYDataGridViewTextBoxColumn"].Value.ToString();
                    iloscPozycji = Convert.ToInt32(ob.Select("POZYCJA_FAKTURY", "COUNT(NUMER_POZYCJI)", "NUMER_FAKTURY", numerFaktury));
                    for (int i = 1; i <= iloscPozycji; i++)
                    {
                        idUslugi = ob.Select("POZYCJA_FAKTURY", "ID_USLUGI", "NUMER_FAKTURY", $"{numerFaktury}' and NUMER_POZYCJI = '{i}");
                        idVat = ob.Select("POZYCJA_FAKTURY", "ID_VAT", "NUMER_FAKTURY", $"{numerFaktury}' and NUMER_POZYCJI = '{i}");
                        iloscString = ob.Select("POZYCJA_FAKTURY", "ILOSC", "NUMER_FAKTURY", $"{numerFaktury}' and NUMER_POZYCJI = '{i}");
                        if (float.TryParse(iloscString, NumberStyles.Any, culture, out ilosc))
                        {
                            // Konwersja się powiodła, ilosc zawiera przekonwertowaną wartość
                        }
                        else
                        {
                            ilosc = 0;
                        }

                        cenaJednostkowaString = ob.Select("USLUGA", "CENA_JEDNOSTKOWA", "ID_USLUGI", idUslugi);
                        if (float.TryParse(cenaJednostkowaString, NumberStyles.Any, culture, out cenaJednostkowa))
                        {
                            // Konwersja się powiodła, ilosc zawiera przekonwertowaną wartość
                        }
                        else
                        {
                            cenaJednostkowa = 0;
                        }

                        wartoscNetto = (float)Math.Round(ilosc * cenaJednostkowa, 2);
                        wartoscNettoSuma += wartoscNetto;

                        procentVatString = ob.Select("STAWKA_VAT", "PROCENT_VAT", "ID_VAT", idVat);
                        procentVat = Convert.ToInt32(procentVatString);
                        wartoscVat = (float)Math.Round(wartoscNetto * procentVat / 100, 2);
                        wartoscVatSuma += wartoscVat;

                        wartoscBrutto = wartoscNetto + wartoscVat;
                        wartoscBruttoSuma += wartoscBrutto;
                    }
                }
                row.Cells["wartoscNetto"].Value = wartoscNettoSuma;
                row.Cells["wartoscVat"].Value = wartoscVatSuma;
                row.Cells["wartoscBrutto"].Value = wartoscBruttoSuma;
            }
            #endregion
        }
    }
}
