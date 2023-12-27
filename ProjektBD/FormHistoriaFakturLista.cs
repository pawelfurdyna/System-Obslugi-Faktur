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
    public partial class FormHistoriaFakturLista : Form
    {
        public FormHistoriaFakturLista()
        {
            InitializeComponent();
        }

        private void FormHistoriaFakturLista_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSetBD.UZYTKOWNIK' . Możesz go przenieść lub usunąć.
            this.uZYTKOWNIKTableAdapter.Fill(this.dataSetBD.UZYTKOWNIK);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSetBD.FAKTURA' . Możesz go przenieść lub usunąć.
            this.fAKTURATableAdapter.Fill(this.dataSetBD.FAKTURA);

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
