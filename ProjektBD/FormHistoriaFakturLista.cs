﻿using System;
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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDDataSetFaktura.FAKTURA' . Możesz go przenieść lub usunąć.
            this.fAKTURATableAdapter.Fill(this.bDDataSetFaktura.FAKTURA);

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {

        }
    }
}
