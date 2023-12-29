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
    public partial class FormKlientLista : Form
    {
        public FormKlientLista()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FormKlientLista_Activated);
        }

        private void FormKlientLista_Activated(object sender, EventArgs e)
        {
            // Refresh data when the form becomes active
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormKlient"] as FormKlient) == null)
            {
                Form klient = new FormKlient();
                klient.Text = "Dodaj";
                klient.ShowDialog();
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            int wiersz = dgvData.CurrentRow.Index;
            int kolumna = dgvData.Columns.IndexOf(iDKLIENTADataGridViewTextBoxColumn);
            string nazwa = dgvData.Rows[wiersz].Cells[kolumna].Value.ToString();
            if ((Application.OpenForms["FormKlient"] as FormKlient) == null)
            {
                Form klient = new FormKlient(true, nazwa);
                klient.ShowDialog();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int wiersz = dgvData.CurrentRow.Index;
            int kolumna = dgvData.Columns.IndexOf(iDKLIENTADataGridViewTextBoxColumn);
            string nazwa = dgvData.Rows[wiersz].Cells[kolumna].Value.ToString();
            DialogResult dr = MessageBox.Show($"Czy napewno chcesz usunąć \"{nazwa}\" ?",
                      "Usunąć?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dr)
            {
                case DialogResult.Yes:
                    string connectionString = ConfigurationManager.ConnectionStrings["ProjektBD.Properties.Settings.ConnectionString"].ConnectionString;
                    using (OracleConnection conn = new OracleConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (OracleCommand cmd = new OracleCommand($"DELETE FROM STAWKA_VAT WHERE id_vat='{nazwa}'", conn))
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
                            conn.Close();
                        }
                        catch (OracleException ex)
                        {
                            MessageBox.Show($"Wystąpił błąd bazy danych. \nError : {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            conn.Close();
                        }
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
