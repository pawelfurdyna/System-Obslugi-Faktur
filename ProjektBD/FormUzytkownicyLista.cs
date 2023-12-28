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
    public partial class FormUzytkownicyLista : Form
    {
        public FormUzytkownicyLista()
        {
            InitializeComponent();
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
    }
}
