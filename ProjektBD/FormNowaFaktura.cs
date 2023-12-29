using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.KLIENT' . Możesz go przenieść lub usunąć.
            this.kLIENTTableAdapter.Fill(this.bDdataSet.KLIENT);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'bDdataSet.POZYCJA_FAKTURY' . Możesz go przenieść lub usunąć.
            this.pOZYCJA_FAKTURYTableAdapter.Fill(this.bDdataSet.POZYCJA_FAKTURY);
            cbKlient.SelectedItem = null;
            cbUzytkownik.SelectedItem = null;
            ObslugaBazy ob = new ObslugaBazy();
            ob.WypelnijComboBoxZEncji("UZYTKOWNIK",cbUzytkownik,new string[] { "ID_UZYTKOWNIKA","IMIE","NAZWISKO" });

            //wygeneroiwać numer faktury 1/2023
            //data wystawienia /wykonania na dzien dzisiejszy  01-01-2023
            //sporzadził ma sie wypełniać z uzytkownika
        }

        private void cbKlient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //nazwa klienta odczytać id 
            //po id zapytać o adres, nip i termin zapłaty
            //ze zwróconych danych wypełnić pola.
            
        }

        private void cbSposobZaplaty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSposobZaplaty.SelectedIndex == 0)
            {
                this.lbTerminZaplaty.Visible = false;
                this.tbTerminZaplaty.Visible = false;
            }
            else
            {
                this.lbTerminZaplaty.Visible = true;
                this.tbTerminZaplaty.Visible = true;
            }
        }

        private void btZapisz_Click(object sender, EventArgs e)
        {

        }

        private void btAnuluj_Click(object sender, EventArgs e)
        {

        }

        private void cbUzytkownik_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
