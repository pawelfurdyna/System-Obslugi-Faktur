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
    public partial class FormUslugiLista : Form
    {
        string nazwa;
        internal static string encja = "USLUGA";
        internal static string klucz = "ID_USLUGI";
        public FormUslugiLista()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FormUslugiLista_Activated);
        }

        private void FormUslugiLista_Activated(object sender, EventArgs e)
        {
            // Refresh data when the form becomes active
            this.uSLUGATableAdapter.Fill(this.bDdataSet.USLUGA);
        }

        private void FormUslugiLista_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.USLUGA' . Możesz go przenieść lub usunąć.
            this.uSLUGATableAdapter.Fill(this.bDdataSet.USLUGA);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormUsluga"] as FormUsluga) == null)
            {
                Form usluga = new FormUsluga();
                usluga.Text = "Dodaj";
                usluga.ShowDialog();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            int wiersz = dataGridView1.CurrentRow.Index;
            int kolumna = dataGridView1.Columns.IndexOf(iDUSLUGIDataGridViewTextBoxColumn);
            string nazwa = dataGridView1.Rows[wiersz].Cells[kolumna].Value.ToString();
            if ((Application.OpenForms["FormUsluga"] as FormUsluga) == null)
            {
                Form usluga = new FormUsluga(true, nazwa);
                usluga.ShowDialog();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            ObslugaBazy ob = new ObslugaBazy();
            int wiersz = dataGridView1.CurrentRow.Index;
            int kolumna = dataGridView1.Columns.IndexOf(iDUSLUGIDataGridViewTextBoxColumn);
            string nazwa = dataGridView1.Rows[wiersz].Cells[kolumna].Value.ToString();
            ob.UsunRekord(encja, klucz, nazwa);
        }
    }
}
