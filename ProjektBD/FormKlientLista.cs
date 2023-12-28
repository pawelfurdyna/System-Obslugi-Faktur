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
    public partial class FormKlientLista : Form
    {
        public FormKlientLista()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvData.Update();
            MessageBox.Show("test");
            
            //this.sTAWKI_VATTableAdapter.Fill(this.stawki_VAT.STAWKI_VAT);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
