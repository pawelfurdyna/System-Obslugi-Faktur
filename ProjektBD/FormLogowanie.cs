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
    public partial class FormLogowanie : Form
    {
        public FormLogowanie()
        {
            InitializeComponent();
        }

        private void btZaloguj_Click(object sender, EventArgs e)
        {

        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHaslo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogowanie_Load(object sender, EventArgs e)
        {
            //Form start = new SystemObslugiFaktur();
            //start.Show();
        }
    }
}
