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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSetBD.STAWKI_VAT' . Możesz go przenieść lub usunąć.
            this.sTAWKI_VATTableAdapter.Fill(this.dataSetBD.STAWKI_VAT);

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
