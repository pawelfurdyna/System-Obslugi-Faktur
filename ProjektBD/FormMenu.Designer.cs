namespace ProjektBD
{
    partial class SystemObslugiFaktur
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemObslugiFaktur));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNowaFaktura = new System.Windows.Forms.Button();
            this.btnHistoriaFaktur = new System.Windows.Forms.Button();
            this.btnKlienci = new System.Windows.Forms.Button();
            this.btnUslugi = new System.Windows.Forms.Button();
            this.btnStawkiVAT = new System.Windows.Forms.Button();
            this.btnFirma = new System.Windows.Forms.Button();
            this.btnUzytkownicy = new System.Windows.Forms.Button();
            this.lbUzytkownik = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zegar = new System.Windows.Forms.Timer(this.components);
            this.btWyloguj = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // btnNowaFaktura
            // 
            this.btnNowaFaktura.Location = new System.Drawing.Point(12, 51);
            this.btnNowaFaktura.Name = "btnNowaFaktura";
            this.btnNowaFaktura.Size = new System.Drawing.Size(100, 100);
            this.btnNowaFaktura.TabIndex = 1;
            this.btnNowaFaktura.Text = "Nowa faktura";
            this.btnNowaFaktura.UseVisualStyleBackColor = true;
            this.btnNowaFaktura.Click += new System.EventHandler(this.btnNowaFaktura_Click);
            // 
            // btnHistoriaFaktur
            // 
            this.btnHistoriaFaktur.Location = new System.Drawing.Point(122, 51);
            this.btnHistoriaFaktur.Name = "btnHistoriaFaktur";
            this.btnHistoriaFaktur.Size = new System.Drawing.Size(100, 100);
            this.btnHistoriaFaktur.TabIndex = 2;
            this.btnHistoriaFaktur.Text = "Historia faktur";
            this.btnHistoriaFaktur.UseVisualStyleBackColor = true;
            this.btnHistoriaFaktur.Click += new System.EventHandler(this.btnHistoriaFaktur_Click);
            // 
            // btnKlienci
            // 
            this.btnKlienci.Location = new System.Drawing.Point(12, 169);
            this.btnKlienci.Name = "btnKlienci";
            this.btnKlienci.Size = new System.Drawing.Size(100, 100);
            this.btnKlienci.TabIndex = 3;
            this.btnKlienci.Text = "Klienci";
            this.btnKlienci.UseVisualStyleBackColor = true;
            this.btnKlienci.Click += new System.EventHandler(this.btnKlienci_Click);
            // 
            // btnUslugi
            // 
            this.btnUslugi.Location = new System.Drawing.Point(122, 169);
            this.btnUslugi.Name = "btnUslugi";
            this.btnUslugi.Size = new System.Drawing.Size(100, 100);
            this.btnUslugi.TabIndex = 4;
            this.btnUslugi.Text = "Usługi";
            this.btnUslugi.UseVisualStyleBackColor = true;
            this.btnUslugi.Click += new System.EventHandler(this.btnUslugi_Click);
            // 
            // btnStawkiVAT
            // 
            this.btnStawkiVAT.Location = new System.Drawing.Point(232, 169);
            this.btnStawkiVAT.Name = "btnStawkiVAT";
            this.btnStawkiVAT.Size = new System.Drawing.Size(100, 100);
            this.btnStawkiVAT.TabIndex = 5;
            this.btnStawkiVAT.Text = "Stawki VAT";
            this.btnStawkiVAT.UseVisualStyleBackColor = true;
            this.btnStawkiVAT.Click += new System.EventHandler(this.btnStawkiVAT_Click);
            // 
            // btnFirma
            // 
            this.btnFirma.Location = new System.Drawing.Point(342, 169);
            this.btnFirma.Name = "btnFirma";
            this.btnFirma.Size = new System.Drawing.Size(100, 100);
            this.btnFirma.TabIndex = 6;
            this.btnFirma.Text = "Firma";
            this.btnFirma.UseVisualStyleBackColor = true;
            this.btnFirma.Click += new System.EventHandler(this.btnFirma_Click);
            // 
            // btnUzytkownicy
            // 
            this.btnUzytkownicy.Location = new System.Drawing.Point(452, 169);
            this.btnUzytkownicy.Name = "btnUzytkownicy";
            this.btnUzytkownicy.Size = new System.Drawing.Size(100, 100);
            this.btnUzytkownicy.TabIndex = 7;
            this.btnUzytkownicy.Text = "Użytkownicy";
            this.btnUzytkownicy.UseVisualStyleBackColor = true;
            this.btnUzytkownicy.Click += new System.EventHandler(this.btnUzytkownicy_Click);
            // 
            // lbUzytkownik
            // 
            this.lbUzytkownik.AutoSize = true;
            this.lbUzytkownik.Location = new System.Drawing.Point(11, 14);
            this.lbUzytkownik.Name = "lbUzytkownik";
            this.lbUzytkownik.Size = new System.Drawing.Size(52, 13);
            this.lbUzytkownik.TabIndex = 8;
            this.lbUzytkownik.Text = "tempUser";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(474, 7);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(53, 13);
            this.lbData.TabIndex = 9;
            this.lbData.Text = "tempDate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.lbUzytkownik);
            this.groupBox1.Location = new System.Drawing.Point(1, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 36);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // zegar
            // 
            this.zegar.Tick += new System.EventHandler(this.zegar_Tick);
            // 
            // btWyloguj
            // 
            this.btWyloguj.Location = new System.Drawing.Point(497, 27);
            this.btWyloguj.Name = "btWyloguj";
            this.btWyloguj.Size = new System.Drawing.Size(75, 22);
            this.btWyloguj.TabIndex = 11;
            this.btWyloguj.Text = "Wyloguj";
            this.btWyloguj.UseVisualStyleBackColor = true;
            this.btWyloguj.Click += new System.EventHandler(this.btWyloguj_Click);
            // 
            // SystemObslugiFaktur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btWyloguj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUzytkownicy);
            this.Controls.Add(this.btnFirma);
            this.Controls.Add(this.btnStawkiVAT);
            this.Controls.Add(this.btnUslugi);
            this.Controls.Add(this.btnKlienci);
            this.Controls.Add(this.btnHistoriaFaktur);
            this.Controls.Add(this.btnNowaFaktura);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "SystemObslugiFaktur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Obslugi Faktur";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Button btnNowaFaktura;
        private System.Windows.Forms.Button btnHistoriaFaktur;
        private System.Windows.Forms.Button btnKlienci;
        private System.Windows.Forms.Button btnUslugi;
        private System.Windows.Forms.Button btnStawkiVAT;
        private System.Windows.Forms.Button btnFirma;
        private System.Windows.Forms.Button btnUzytkownicy;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Label lbUzytkownik;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer zegar;
        private System.Windows.Forms.Button btWyloguj;
    }
}

