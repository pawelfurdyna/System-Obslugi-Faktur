namespace ProjektBD
{
    partial class FormNowaFaktura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNowaFaktura));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAdresKlienta = new System.Windows.Forms.Label();
            this.lbMiejsceWystawienia = new System.Windows.Forms.Label();
            this.lbSposobZaplaty = new System.Windows.Forms.Label();
            this.lbDataWykonaniaUslugi = new System.Windows.Forms.Label();
            this.lbDataWystawienia = new System.Windows.Forms.Label();
            this.tbAdresKlienta = new System.Windows.Forms.TextBox();
            this.tbMiejsceWystawienia = new System.Windows.Forms.TextBox();
            this.tbDataWykonaniaUslugi = new System.Windows.Forms.TextBox();
            this.tbDataWystawienia = new System.Windows.Forms.TextBox();
            this.tbNipKlienta = new System.Windows.Forms.TextBox();
            this.lbNipKlienta = new System.Windows.Forms.Label();
            this.tbNrFaktury = new System.Windows.Forms.TextBox();
            this.lbNrFaktury = new System.Windows.Forms.Label();
            this.lbTerminZaplaty = new System.Windows.Forms.Label();
            this.tbTerminZaplaty = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usluga = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscBrutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOZYCJAFAKTURYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDdataSet = new ProjektBD.BDDataSet();
            this.lbSporzadzil = new System.Windows.Forms.Label();
            this.pOZYCJA_FAKTURYTableAdapter = new ProjektBD.BDDataSetTableAdapters.POZYCJA_FAKTURYTableAdapter();
            this.cbKlient = new System.Windows.Forms.ComboBox();
            this.kLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbKlient = new System.Windows.Forms.Label();
            this.cbSposobZaplaty = new System.Windows.Forms.ComboBox();
            this.kLIENTTableAdapter = new ProjektBD.BDDataSetTableAdapters.KLIENTTableAdapter();
            this.btZapisz = new System.Windows.Forms.Button();
            this.btAnuluj = new System.Windows.Forms.Button();
            this.cbUzytkownik = new System.Windows.Forms.ComboBox();
            this.uZYTKOWNIKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uZYTKOWNIKTableAdapter = new ProjektBD.BDDataSetTableAdapters.UZYTKOWNIKTableAdapter();
            this.uSLUGABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSLUGATableAdapter = new ProjektBD.BDDataSetTableAdapters.USLUGATableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOZYCJAFAKTURYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uZYTKOWNIKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSLUGABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 18;
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
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.zakończToolStripMenuItem.Text = "Zamknij Okno";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // lbAdresKlienta
            // 
            this.lbAdresKlienta.AutoSize = true;
            this.lbAdresKlienta.Location = new System.Drawing.Point(12, 112);
            this.lbAdresKlienta.Name = "lbAdresKlienta";
            this.lbAdresKlienta.Size = new System.Drawing.Size(71, 13);
            this.lbAdresKlienta.TabIndex = 32;
            this.lbAdresKlienta.Text = "Adres klienta:";
            // 
            // lbMiejsceWystawienia
            // 
            this.lbMiejsceWystawienia.AutoSize = true;
            this.lbMiejsceWystawienia.Location = new System.Drawing.Point(11, 131);
            this.lbMiejsceWystawienia.Name = "lbMiejsceWystawienia";
            this.lbMiejsceWystawienia.Size = new System.Drawing.Size(106, 13);
            this.lbMiejsceWystawienia.TabIndex = 31;
            this.lbMiejsceWystawienia.Text = "Miejsce wystawienia:";
            // 
            // lbSposobZaplaty
            // 
            this.lbSposobZaplaty.AutoSize = true;
            this.lbSposobZaplaty.Location = new System.Drawing.Point(428, 86);
            this.lbSposobZaplaty.Name = "lbSposobZaplaty";
            this.lbSposobZaplaty.Size = new System.Drawing.Size(84, 13);
            this.lbSposobZaplaty.TabIndex = 30;
            this.lbSposobZaplaty.Text = "Sposób zapłaty:";
            // 
            // lbDataWykonaniaUslugi
            // 
            this.lbDataWykonaniaUslugi.AutoSize = true;
            this.lbDataWykonaniaUslugi.Location = new System.Drawing.Point(427, 60);
            this.lbDataWykonaniaUslugi.Name = "lbDataWykonaniaUslugi";
            this.lbDataWykonaniaUslugi.Size = new System.Drawing.Size(119, 13);
            this.lbDataWykonaniaUslugi.TabIndex = 29;
            this.lbDataWykonaniaUslugi.Text = "Data wykonania usługi:";
            // 
            // lbDataWystawienia
            // 
            this.lbDataWystawienia.AutoSize = true;
            this.lbDataWystawienia.Location = new System.Drawing.Point(428, 34);
            this.lbDataWystawienia.Name = "lbDataWystawienia";
            this.lbDataWystawienia.Size = new System.Drawing.Size(93, 13);
            this.lbDataWystawienia.TabIndex = 28;
            this.lbDataWystawienia.Text = "Data wystawienia:";
            // 
            // tbAdresKlienta
            // 
            this.tbAdresKlienta.Location = new System.Drawing.Point(122, 105);
            this.tbAdresKlienta.Name = "tbAdresKlienta";
            this.tbAdresKlienta.Size = new System.Drawing.Size(276, 20);
            this.tbAdresKlienta.TabIndex = 27;
            // 
            // tbMiejsceWystawienia
            // 
            this.tbMiejsceWystawienia.Location = new System.Drawing.Point(122, 131);
            this.tbMiejsceWystawienia.Name = "tbMiejsceWystawienia";
            this.tbMiejsceWystawienia.Size = new System.Drawing.Size(276, 20);
            this.tbMiejsceWystawienia.TabIndex = 26;
            // 
            // tbDataWykonaniaUslugi
            // 
            this.tbDataWykonaniaUslugi.Location = new System.Drawing.Point(552, 53);
            this.tbDataWykonaniaUslugi.Name = "tbDataWykonaniaUslugi";
            this.tbDataWykonaniaUslugi.Size = new System.Drawing.Size(262, 20);
            this.tbDataWykonaniaUslugi.TabIndex = 24;
            this.tbDataWykonaniaUslugi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDataWykonaniaUslugi_KeyPress);
            this.tbDataWykonaniaUslugi.Validating += new System.ComponentModel.CancelEventHandler(this.tbDataWykonaniaUslugi_Validating);
            // 
            // tbDataWystawienia
            // 
            this.tbDataWystawienia.Location = new System.Drawing.Point(552, 27);
            this.tbDataWystawienia.Name = "tbDataWystawienia";
            this.tbDataWystawienia.Size = new System.Drawing.Size(262, 20);
            this.tbDataWystawienia.TabIndex = 23;
            this.tbDataWystawienia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDataWystawienia_KeyPress);
            this.tbDataWystawienia.Validating += new System.ComponentModel.CancelEventHandler(this.tbDataWystawienia_Validating);
            // 
            // tbNipKlienta
            // 
            this.tbNipKlienta.Location = new System.Drawing.Point(122, 79);
            this.tbNipKlienta.MaxLength = 11;
            this.tbNipKlienta.Name = "tbNipKlienta";
            this.tbNipKlienta.Size = new System.Drawing.Size(276, 20);
            this.tbNipKlienta.TabIndex = 22;
            // 
            // lbNipKlienta
            // 
            this.lbNipKlienta.AutoSize = true;
            this.lbNipKlienta.Location = new System.Drawing.Point(12, 86);
            this.lbNipKlienta.Name = "lbNipKlienta";
            this.lbNipKlienta.Size = new System.Drawing.Size(62, 13);
            this.lbNipKlienta.TabIndex = 21;
            this.lbNipKlienta.Text = "NIP klienta:";
            // 
            // tbNrFaktury
            // 
            this.tbNrFaktury.Location = new System.Drawing.Point(122, 27);
            this.tbNrFaktury.MaxLength = 4;
            this.tbNrFaktury.Name = "tbNrFaktury";
            this.tbNrFaktury.Size = new System.Drawing.Size(276, 20);
            this.tbNrFaktury.TabIndex = 20;
            this.tbNrFaktury.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNrFaktury_KeyPress);
            // 
            // lbNrFaktury
            // 
            this.lbNrFaktury.AutoSize = true;
            this.lbNrFaktury.Location = new System.Drawing.Point(12, 34);
            this.lbNrFaktury.Name = "lbNrFaktury";
            this.lbNrFaktury.Size = new System.Drawing.Size(56, 13);
            this.lbNrFaktury.TabIndex = 19;
            this.lbNrFaktury.Text = "Nr faktury:";
            // 
            // lbTerminZaplaty
            // 
            this.lbTerminZaplaty.AutoSize = true;
            this.lbTerminZaplaty.Location = new System.Drawing.Point(428, 112);
            this.lbTerminZaplaty.Name = "lbTerminZaplaty";
            this.lbTerminZaplaty.Size = new System.Drawing.Size(103, 13);
            this.lbTerminZaplaty.TabIndex = 34;
            this.lbTerminZaplaty.Text = "Termin zapłaty (dni):";
            this.lbTerminZaplaty.Visible = false;
            // 
            // tbTerminZaplaty
            // 
            this.tbTerminZaplaty.Location = new System.Drawing.Point(552, 105);
            this.tbTerminZaplaty.MaxLength = 2;
            this.tbTerminZaplaty.Name = "tbTerminZaplaty";
            this.tbTerminZaplaty.Size = new System.Drawing.Size(262, 20);
            this.tbTerminZaplaty.TabIndex = 33;
            this.tbTerminZaplaty.Visible = false;
            this.tbTerminZaplaty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTerminZaplaty_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lp,
            this.usluga,
            this.jm,
            this.ilosc,
            this.cenaJednostkowa,
            this.netto,
            this.procentVat,
            this.wartoscVat,
            this.wartoscBrutto});
            this.dataGridView1.Location = new System.Drawing.Point(14, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 220);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView1_CellStateChanged);
            // 
            // lp
            // 
            this.lp.HeaderText = "Lp.";
            this.lp.Name = "lp";
            // 
            // usluga
            // 
            this.usluga.HeaderText = "Usługa";
            this.usluga.Name = "usluga";
            this.usluga.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.usluga.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // jm
            // 
            this.jm.HeaderText = "j.m.";
            this.jm.Name = "jm";
            // 
            // ilosc
            // 
            this.ilosc.HeaderText = "Ilość";
            this.ilosc.Name = "ilosc";
            // 
            // cenaJednostkowa
            // 
            this.cenaJednostkowa.HeaderText = "Cena jednostkowa";
            this.cenaJednostkowa.Name = "cenaJednostkowa";
            // 
            // netto
            // 
            this.netto.HeaderText = "Wartość Netto";
            this.netto.Name = "netto";
            // 
            // procentVat
            // 
            this.procentVat.HeaderText = "%VAT";
            this.procentVat.Name = "procentVat";
            // 
            // wartoscVat
            // 
            this.wartoscVat.HeaderText = "Wartość VAT";
            this.wartoscVat.Name = "wartoscVat";
            // 
            // wartoscBrutto
            // 
            this.wartoscBrutto.HeaderText = "Wartość Brutto";
            this.wartoscBrutto.Name = "wartoscBrutto";
            // 
            // pOZYCJAFAKTURYBindingSource
            // 
            this.pOZYCJAFAKTURYBindingSource.DataMember = "POZYCJA_FAKTURY";
            this.pOZYCJAFAKTURYBindingSource.DataSource = this.bDdataSet;
            // 
            // bDdataSet
            // 
            this.bDdataSet.DataSetName = "DataSetBD";
            this.bDdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbSporzadzil
            // 
            this.lbSporzadzil.AutoSize = true;
            this.lbSporzadzil.Location = new System.Drawing.Point(12, 399);
            this.lbSporzadzil.Name = "lbSporzadzil";
            this.lbSporzadzil.Size = new System.Drawing.Size(60, 13);
            this.lbSporzadzil.TabIndex = 37;
            this.lbSporzadzil.Text = "Sporządził:";
            // 
            // pOZYCJA_FAKTURYTableAdapter
            // 
            this.pOZYCJA_FAKTURYTableAdapter.ClearBeforeFill = true;
            // 
            // cbKlient
            // 
            this.cbKlient.DataSource = this.kLIENTBindingSource;
            this.cbKlient.DisplayMember = "NAZWA";
            this.cbKlient.FormattingEnabled = true;
            this.cbKlient.Location = new System.Drawing.Point(122, 52);
            this.cbKlient.Name = "cbKlient";
            this.cbKlient.Size = new System.Drawing.Size(276, 21);
            this.cbKlient.TabIndex = 38;
            this.cbKlient.ValueMember = "ID_KLIENTA";
            this.cbKlient.SelectedIndexChanged += new System.EventHandler(this.cbKlient_SelectedIndexChanged);
            // 
            // kLIENTBindingSource
            // 
            this.kLIENTBindingSource.DataMember = "KLIENT";
            this.kLIENTBindingSource.DataSource = this.bDdataSet;
            // 
            // lbKlient
            // 
            this.lbKlient.AutoSize = true;
            this.lbKlient.Location = new System.Drawing.Point(12, 60);
            this.lbKlient.Name = "lbKlient";
            this.lbKlient.Size = new System.Drawing.Size(36, 13);
            this.lbKlient.TabIndex = 39;
            this.lbKlient.Text = "Klient:";
            // 
            // cbSposobZaplaty
            // 
            this.cbSposobZaplaty.FormattingEnabled = true;
            this.cbSposobZaplaty.Items.AddRange(new object[] {
            "Gotówka",
            "Przelew"});
            this.cbSposobZaplaty.Location = new System.Drawing.Point(552, 79);
            this.cbSposobZaplaty.Name = "cbSposobZaplaty";
            this.cbSposobZaplaty.Size = new System.Drawing.Size(262, 21);
            this.cbSposobZaplaty.TabIndex = 40;
            this.cbSposobZaplaty.SelectedIndexChanged += new System.EventHandler(this.cbSposobZaplaty_SelectedIndexChanged);
            // 
            // kLIENTTableAdapter
            // 
            this.kLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // btZapisz
            // 
            this.btZapisz.Location = new System.Drawing.Point(658, 415);
            this.btZapisz.Name = "btZapisz";
            this.btZapisz.Size = new System.Drawing.Size(75, 23);
            this.btZapisz.TabIndex = 41;
            this.btZapisz.Text = "Zapisz";
            this.btZapisz.UseVisualStyleBackColor = true;
            this.btZapisz.Click += new System.EventHandler(this.btZapisz_Click);
            // 
            // btAnuluj
            // 
            this.btAnuluj.Location = new System.Drawing.Point(739, 415);
            this.btAnuluj.Name = "btAnuluj";
            this.btAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btAnuluj.TabIndex = 42;
            this.btAnuluj.Text = "Anuluj";
            this.btAnuluj.UseVisualStyleBackColor = true;
            this.btAnuluj.Click += new System.EventHandler(this.btAnuluj_Click);
            // 
            // cbUzytkownik
            // 
            this.cbUzytkownik.FormattingEnabled = true;
            this.cbUzytkownik.Location = new System.Drawing.Point(78, 396);
            this.cbUzytkownik.Name = "cbUzytkownik";
            this.cbUzytkownik.Size = new System.Drawing.Size(319, 21);
            this.cbUzytkownik.TabIndex = 43;
            this.cbUzytkownik.Tag = "";
            // 
            // uZYTKOWNIKBindingSource
            // 
            this.uZYTKOWNIKBindingSource.DataMember = "UZYTKOWNIK";
            this.uZYTKOWNIKBindingSource.DataSource = this.bDdataSet;
            // 
            // uZYTKOWNIKTableAdapter
            // 
            this.uZYTKOWNIKTableAdapter.ClearBeforeFill = true;
            // 
            // uSLUGABindingSource
            // 
            this.uSLUGABindingSource.DataMember = "USLUGA";
            this.uSLUGABindingSource.DataSource = this.bDdataSet;
            // 
            // uSLUGATableAdapter
            // 
            this.uSLUGATableAdapter.ClearBeforeFill = true;
            // 
            // FormNowaFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.cbUzytkownik);
            this.Controls.Add(this.btAnuluj);
            this.Controls.Add(this.btZapisz);
            this.Controls.Add(this.cbSposobZaplaty);
            this.Controls.Add(this.lbKlient);
            this.Controls.Add(this.cbKlient);
            this.Controls.Add(this.lbSporzadzil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbTerminZaplaty);
            this.Controls.Add(this.tbTerminZaplaty);
            this.Controls.Add(this.lbAdresKlienta);
            this.Controls.Add(this.lbMiejsceWystawienia);
            this.Controls.Add(this.lbSposobZaplaty);
            this.Controls.Add(this.lbDataWykonaniaUslugi);
            this.Controls.Add(this.lbDataWystawienia);
            this.Controls.Add(this.tbAdresKlienta);
            this.Controls.Add(this.tbMiejsceWystawienia);
            this.Controls.Add(this.tbDataWykonaniaUslugi);
            this.Controls.Add(this.tbDataWystawienia);
            this.Controls.Add(this.tbNipKlienta);
            this.Controls.Add(this.lbNipKlienta);
            this.Controls.Add(this.tbNrFaktury);
            this.Controls.Add(this.lbNrFaktury);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNowaFaktura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nowa Faktura";
            this.Load += new System.EventHandler(this.FormNowaFaktura_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOZYCJAFAKTURYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uZYTKOWNIKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSLUGABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Label lbAdresKlienta;
        private System.Windows.Forms.Label lbMiejsceWystawienia;
        private System.Windows.Forms.Label lbSposobZaplaty;
        private System.Windows.Forms.Label lbDataWykonaniaUslugi;
        private System.Windows.Forms.Label lbDataWystawienia;
        private System.Windows.Forms.TextBox tbAdresKlienta;
        private System.Windows.Forms.TextBox tbMiejsceWystawienia;
        private System.Windows.Forms.TextBox tbDataWykonaniaUslugi;
        private System.Windows.Forms.TextBox tbDataWystawienia;
        private System.Windows.Forms.TextBox tbNipKlienta;
        private System.Windows.Forms.Label lbNipKlienta;
        private System.Windows.Forms.TextBox tbNrFaktury;
        private System.Windows.Forms.Label lbNrFaktury;
        private System.Windows.Forms.Label lbTerminZaplaty;
        private System.Windows.Forms.TextBox tbTerminZaplaty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSporzadzil;
        private BDDataSet bDdataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAWKAVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pOZYCJAFAKTURYBindingSource;
        private BDDataSetTableAdapters.POZYCJA_FAKTURYTableAdapter pOZYCJA_FAKTURYTableAdapter;
        private System.Windows.Forms.ComboBox cbKlient;
        private System.Windows.Forms.Label lbKlient;
        private System.Windows.Forms.ComboBox cbSposobZaplaty;
        private System.Windows.Forms.BindingSource kLIENTBindingSource;
        private BDDataSetTableAdapters.KLIENTTableAdapter kLIENTTableAdapter;
        private System.Windows.Forms.Button btZapisz;
        private System.Windows.Forms.Button btAnuluj;
        private System.Windows.Forms.ComboBox cbUzytkownik;
        private System.Windows.Forms.BindingSource uZYTKOWNIKBindingSource;
        private BDDataSetTableAdapters.UZYTKOWNIKTableAdapter uZYTKOWNIKTableAdapter;
        private System.Windows.Forms.BindingSource uSLUGABindingSource;
        private BDDataSetTableAdapters.USLUGATableAdapter uSLUGATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lp;
        private System.Windows.Forms.DataGridViewComboBoxColumn usluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn netto;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscBrutto;
    }
}