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
    public partial class FormFirma : Form
    {
        public FormFirma()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.btnEdytuj.Text == "Edytuj")
            {
                this.lbKodPocztowy.Enabled = true;
                this.lbKontoBankowe.Enabled = true;
                this.lbMiejscowosc.Enabled = true;
                this.lbNazwaFirmy.Enabled = true;
                this.lbNip.Enabled = true;
                this.lbTelefonFirmowy.Enabled = true;
                this.lbUlica.Enabled = true;
                this.tbKodPocztowy.Enabled = true;
                this.tbKontoBankowe.Enabled = true;
                this.tbMiejscowosc.Enabled = true;
                this.tbNazwaFirmy.Enabled = true;
                this.tbNip.Enabled = true;
                this.tbTelefonFirmowy.Enabled = true;
                this.tbUlica.Enabled = true;
                this.btnZapisz.Visible = true;
                this.btnEdytuj.Text = "Anuluj";
                this.btnEdytuj.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                this.lbKodPocztowy.Enabled = false;
                this.lbKontoBankowe.Enabled = false;
                this.lbMiejscowosc.Enabled = false;
                this.lbNazwaFirmy.Enabled = false;
                this.lbNip.Enabled = false;
                this.lbTelefonFirmowy.Enabled = false;
                this.lbUlica.Enabled = false;
                this.tbKodPocztowy.Enabled = false;
                this.tbKontoBankowe.Enabled = false;
                this.tbMiejscowosc.Enabled = false;
                this.tbNazwaFirmy.Enabled = false;
                this.tbNip.Enabled = false;
                this.tbTelefonFirmowy.Enabled = false;
                this.tbUlica.Enabled = false;
                this.btnZapisz.Visible = false;
                this.btnEdytuj.Text = "Edytuj";
                this.btnEdytuj.BackColor = SystemColors.Control;
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
