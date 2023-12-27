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
    public partial class FormUslugiLista : Form
    {
        public FormUslugiLista()
        {
            InitializeComponent();
        }

        private void FormUslugiLista_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSetBD.USLUGI' . Możesz go przenieść lub usunąć.
            this.uSLUGITableAdapter.Fill(this.dataSetBD.USLUGI);

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
