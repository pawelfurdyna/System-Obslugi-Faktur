using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public FormStawkiVatLista()
        {
            InitializeComponent();
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
                stawkaVat.Show();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {

            if ((Application.OpenForms["FormStawkaVAT"] as FormStawkaVAT) == null)
            {
                Form stawkaVat = new FormStawkaVAT();
                stawkaVat.Show();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

        }
    }
}
