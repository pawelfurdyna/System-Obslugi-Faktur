﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        internal static string encja = "KLIENT";
        internal static string klucz = "ID_KLIENTA";
        ObslugaBazy ob = new ObslugaBazy();
        public FormKlientLista()
        {
            InitializeComponent();
            this.Activated += new EventHandler(FormKlientLista_Activated);
        }

        private void FormKlientLista_Activated(object sender, EventArgs e)
        {
            // Refresh data when the form becomes active
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormKlient"] as FormKlient) == null)
            {
                Form klient = new FormKlient();
                klient.Text = "Dodaj";
                klient.ShowDialog();
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            int wiersz = dgvData.CurrentRow.Index;
            int kolumna = dgvData.Columns.IndexOf(iDKLIENTADataGridViewTextBoxColumn);
            string nazwa = dgvData.Rows[wiersz].Cells[kolumna].Value.ToString();
            if ((Application.OpenForms["FormKlient"] as FormKlient) == null)
            {
                Form klient = new FormKlient(true, nazwa);
                klient.ShowDialog();
            }
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            int wiersz = dgvData.CurrentRow.Index;
            int kolumnaId = dgvData.Columns.IndexOf(iDKLIENTADataGridViewTextBoxColumn);
            int kolumnaNazwa = dgvData.Columns.IndexOf(nAZWADataGridViewTextBoxColumn);
            string id = dgvData.Rows[wiersz].Cells[kolumnaId].Value.ToString();
            string nazwa = dgvData.Rows[wiersz].Cells[kolumnaNazwa].Value.ToString();
            ob.UsunRekord(encja, klucz, id, nazwa);
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
        }

        private void FormKlientLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormPomoc"] as FormPomoc) == null)
            {
                FormPomoc pomoc = new FormPomoc();
                pomoc.Show();
            }
        }
    }
}
