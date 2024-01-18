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
        ObslugaBazy ob = new ObslugaBazy();
        
        public SystemObslugiFaktur()
        {
            InitializeComponent();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            string rolaUzytkownika = "";
            string zmienna = "Użytkownik: \n" + FormLogowanie.obecnyUzytkownik;
            lbUzytkownik.Text = zmienna;
            zegar.Start();
            ObslugaBazy ob = new ObslugaBazy();
            FormLogowanie formLogowanie = new FormLogowanie();
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
    #region FormatowanieDlaRoliUzytkownika
            rolaUzytkownika = ob.Select("UZYTKOWNIK", "ROLA", "LOGIN", FormLogowanie.login, true);
            if (rolaUzytkownika == "Admin")
            {
                this.btnFirma.Visible = true;
                this.btnUzytkownicy.Visible = true;
                this.btnStawkiVAT.Visible = true;
                System.Drawing.Point pointForm = new System.Drawing.Point(600, 350);
                this.Size = new System.Drawing.Size(pointForm);
                this.MaximumSize = new System.Drawing.Size(pointForm);
                this.MinimumSize = new System.Drawing.Size(pointForm);
                this.btWyloguj.Location = new System.Drawing.Point(500, 30);
                this.lbData.Location = new System.Drawing.Point(474, 7);
                this.btnNowaFaktura.Location = new System.Drawing.Point(12, 51);
                this.btnHistoriaFaktur.Location = new System.Drawing.Point(122, 51);
                this.btnKlienci.Location = new System.Drawing.Point(12, 169);
                this.btnUslugi.Location = new System.Drawing.Point(122, 169);

            }
            else
            {
                this.btnFirma.Visible=false;
                this.btnUzytkownicy.Visible=false;
                this.btnStawkiVAT.Visible=false;
                System.Drawing.Point point = new System.Drawing.Point(330, 355);
                this.Size = new System.Drawing.Size(point);
                this.MaximumSize = new System.Drawing.Size(point);
                this.MinimumSize = new System.Drawing.Size(point);
                this.lbData.Location = new System.Drawing.Point(240,7);
                this.btWyloguj.Location = new System.Drawing.Point(230, 30);
                this.btnNowaFaktura.Location = new System.Drawing.Point(52, 58);
                this.btnHistoriaFaktur.Location = new System.Drawing.Point(162, 58);
                this.btnKlienci.Location = new System.Drawing.Point(52, 176);
                this.btnUslugi.Location = new System.Drawing.Point(162, 176);
            }
    #endregion
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
