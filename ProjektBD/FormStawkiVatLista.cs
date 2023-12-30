using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBD
{
    public partial class FormStawkiVatLista : Form
    {
        internal static string encja = "STAWKA_VAT";
        internal static string klucz = "ID_VAT";
        ObslugaBazy ob = new ObslugaBazy();

        public FormStawkiVatLista()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FormStawkiVatLista_Activated);
        }
        private void FormStawkiVatLista_Activated(object sender, EventArgs e)
        {
            // Refresh data when the form becomes active
            this.sTAWKA_VATTableAdapter.Fill(this.bDdataSet.STAWKA_VAT);
        }

        private void FormStawkiVatLista_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.STAWKA_VAT' . Możesz go przenieść lub usunąć.
            this.sTAWKA_VATTableAdapter.Fill(this.bDdataSet.STAWKA_VAT);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormStawkaVAT"] as FormStawkaVAT) == null)
            {
                Form stawkaVat = new FormStawkaVAT();
                stawkaVat.Text = "Dodaj";
                stawkaVat.ShowDialog();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            int wiersz = dataGridView1.CurrentRow.Index;
            int kolumna = dataGridView1.Columns.IndexOf(iDVATDataGridViewTextBoxColumn);
            string nazwa = dataGridView1.Rows[wiersz].Cells[kolumna].Value.ToString();
            if ((Application.OpenForms["FormStawkaVAT"] as FormStawkaVAT) == null)
            {
                Form stawkaVat = new FormStawkaVAT(true, nazwa);
                stawkaVat.ShowDialog();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int wiersz = dataGridView1.CurrentRow.Index;
            int kolumna = dataGridView1.Columns.IndexOf(iDVATDataGridViewTextBoxColumn);
            string nazwa = dataGridView1.Rows[wiersz].Cells[kolumna].Value.ToString();
            ob.UsunRekord(encja, klucz, nazwa);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
