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
    public partial class SystemObslugiFaktur : Form
    {
        public SystemObslugiFaktur()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            string zmienna = "Użytkownik: ";
            lbUzytkownik.Text = zmienna;
            zegar.Start();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

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
                ObslugaBazy ob = new ObslugaBazy();
                Form firma = new FormFirma(ob.WczytajFirme("FIRMA"));
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
            string today = DateTime.Now.ToString("dd/MM/yyyy   HH:mm:ss");
            lbData.Text = today;
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
