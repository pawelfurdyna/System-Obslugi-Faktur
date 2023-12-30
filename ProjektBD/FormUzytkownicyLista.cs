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
    public partial class FormUzytkownicyLista : Form
    {
        internal static string encja = "UZYTKOWNIK";
        internal static string klucz = "ID_UZYTKOWNIKA";
        ObslugaBazy ob = new ObslugaBazy();
        public FormUzytkownicyLista()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FormUzytkownicyLista_Activated);
        }

        private void FormUzytkownicyLista_Activated(object sender, EventArgs e)
        {
            // Refresh data when the form becomes active
            this.uZYTKOWNIKTableAdapter.Fill(this.bDdataSet.UZYTKOWNIK);
        }

        private void FormUzytkownicyLista_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.UZYTKOWNIK' . Możesz go przenieść lub usunąć.
            this.uZYTKOWNIKTableAdapter.Fill(this.bDdataSet.UZYTKOWNIK);

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormUzytkownik"] as FormUzytkownik) == null)
            {
                Form uzytkownik = new FormUzytkownik();
                uzytkownik.Text = "Dodaj";
                uzytkownik.ShowDialog();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            int wiersz = dataGridView1.CurrentRow.Index;
            int kolumna = dataGridView1.Columns.IndexOf(iDUZYTKOWNIKADataGridViewTextBoxColumn);
            string nazwa = dataGridView1.Rows[wiersz].Cells[kolumna].Value.ToString();
            if ((Application.OpenForms["FormUzytkownik"] as FormUzytkownik) == null)
            {
                Form uzytkownik = new FormUzytkownik(true, nazwa);
                uzytkownik.ShowDialog();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int wiersz = dataGridView1.CurrentRow.Index;
            int kolumna = dataGridView1.Columns.IndexOf(iDUZYTKOWNIKADataGridViewTextBoxColumn);
            string nazwa = dataGridView1.Rows[wiersz].Cells[kolumna].Value.ToString();
            ob.UsunRekord(encja,klucz,nazwa);
        }
    }
}
