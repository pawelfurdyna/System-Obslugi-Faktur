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
    public partial class FormNowaFaktura : Form
    {
        public FormNowaFaktura()
        {
            InitializeComponent();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNowaFaktura_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dataSetBD.POZYCJA_FAKTURY' . Możesz go przenieść lub usunąć.
            this.pOZYCJA_FAKTURYTableAdapter.Fill(this.dataSetBD.POZYCJA_FAKTURY);

        }
    }
}
