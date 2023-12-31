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
    public partial class SystemObslugiFaktur : Form
    {
        ObslugaBazy ob = new ObslugaBazy();
        public SystemObslugiFaktur()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            string zmienna = "Użytkownik: " + FormLogowanie.obecnyUzytkownik;
            lbUzytkownik.Text = zmienna;
            zegar.Start();
            ObslugaBazy ob = new ObslugaBazy();
            if (ob.Select("FIRMA","NAZWA_FIRMY","","",false) == "")
            {
                if ((Application.OpenForms["FormFirma"] as FormFirma) == null)
                {
                    Form firma = new FormFirma(true);
                    firma.ShowDialog();
                }
            }
            ob = new ObslugaBazy();
            if (ob.Select("FIRMA", "NAZWA_FIRMY", "", "", false) == "")
            {
                Application.Exit();
            }
        }

        private void btnNowaFaktura_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormNowaFaktura"] as FormNowaFaktura) == null)
            {
                Form nowaFaktura = new FormNowaFaktura();
                nowaFaktura.ShowDialog();
            }
        }

        private void btnHistoriaFaktur_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormHistoriaFakturLista"] as FormHistoriaFakturLista) == null)
            {
                Form historia = new FormHistoriaFakturLista();
                historia.Show();
            }
        }

        private void btnKlienci_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormKlientLista"] as FormKlientLista) == null)
            {
                Form klienci = new FormKlientLista();
                klienci.Show();
            }
        }

        private void btnUslugi_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormUslugiLista"] as FormUslugiLista) == null)
            {
                Form uslugi = new FormUslugiLista();
                uslugi.Show();
            }
        }

        private void btnStawkiVAT_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormStawkiVatLista"] as FormStawkiVatLista) == null)
            {
                Form stawkiVat = new FormStawkiVatLista();
                stawkiVat.Show();
            }
        }

        private void btnFirma_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormFirma"] as FormFirma) == null)
            {
                Form firma = new FormFirma(false, ob.Select("FIRMA", "NAZWA_FIRMY", "", "", false));
                firma.ShowDialog();
            }
        }

        private void btnUzytkownicy_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["FormUzytkownicyLista"] as FormUzytkownicyLista) == null)
            {
                Form uzytkownicy = new FormUzytkownicyLista();
                uzytkownicy.Show();
            }
        }

        private void zegar_Tick(object sender, EventArgs e)
        {
            string today = DateTime.Now.ToString("dd/MM/yyyy \n HH:mm:ss");
            lbData.Text = today;
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) { Application.Exit(); }
        }

        private void btWyloguj_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
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
