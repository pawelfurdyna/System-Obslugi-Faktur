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
            this.lbMiejsceWystawienia = new System.Windows.Forms.Label();
            this.lbSposobZaplaty = new System.Windows.Forms.Label();
            this.lbDataWykonaniaUslugi = new System.Windows.Forms.Label();
            this.lbDataWystawienia = new System.Windows.Forms.Label();
            this.tbMiejsceWystawienia = new System.Windows.Forms.TextBox();
            this.tbDataWykonaniaUslugi = new System.Windows.Forms.TextBox();
            this.tbDataWystawienia = new System.Windows.Forms.TextBox();
            this.lbNrFaktury = new System.Windows.Forms.Label();
            this.lbTerminZaplaty = new System.Windows.Forms.Label();
            this.tbTerminZaplaty = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usluga = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaJednostkowa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscNetto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentVat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.wartoscVat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscBrutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAWKAVATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDdataSet = new ProjektBD.BDDataSet();
            this.pOZYCJAFAKTURYBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.sTAWKA_VATTableAdapter = new ProjektBD.BDDataSetTableAdapters.STAWKA_VATTableAdapter();
            this.lbSumaNetto = new System.Windows.Forms.Label();
            this.lbSumaVat = new System.Windows.Forms.Label();
            this.lbSumaBrutto = new System.Windows.Forms.Label();
            this.lbSumaNettoWartosc = new System.Windows.Forms.Label();
            this.lbSumaVatWartosc = new System.Windows.Forms.Label();
            this.lbSumaBruttoWartosc = new System.Windows.Forms.Label();
            this.lbUwagi = new System.Windows.Forms.Label();
            this.tbUwagi = new System.Windows.Forms.TextBox();
            this.lbNrFakturyWartosc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKAVATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOZYCJAFAKTURYBindingSource)).BeginInit();
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
            // lbMiejsceWystawienia
            // 
            this.lbMiejsceWystawienia.AutoSize = true;
            this.lbMiejsceWystawienia.Location = new System.Drawing.Point(12, 82);
            this.lbMiejsceWystawienia.Name = "lbMiejsceWystawienia";
            this.lbMiejsceWystawienia.Size = new System.Drawing.Size(106, 13);
            this.lbMiejsceWystawienia.TabIndex = 31;
            this.lbMiejsceWystawienia.Text = "Miejsce wystawienia:";
            // 
            // lbSposobZaplaty
            // 
            this.lbSposobZaplaty.AutoSize = true;
            this.lbSposobZaplaty.Location = new System.Drawing.Point(427, 82);
            this.lbSposobZaplaty.Name = "lbSposobZaplaty";
            this.lbSposobZaplaty.Size = new System.Drawing.Size(84, 13);
            this.lbSposobZaplaty.TabIndex = 30;
            this.lbSposobZaplaty.Text = "Sposób zapłaty:";
            // 
            // lbDataWykonaniaUslugi
            // 
            this.lbDataWykonaniaUslugi.AutoSize = true;
            this.lbDataWykonaniaUslugi.Location = new System.Drawing.Point(427, 55);
            this.lbDataWykonaniaUslugi.Name = "lbDataWykonaniaUslugi";
            this.lbDataWykonaniaUslugi.Size = new System.Drawing.Size(119, 13);
            this.lbDataWykonaniaUslugi.TabIndex = 29;
            this.lbDataWykonaniaUslugi.Text = "Data wykonania usługi:";
            // 
            // lbDataWystawienia
            // 
            this.lbDataWystawienia.AutoSize = true;
            this.lbDataWystawienia.Location = new System.Drawing.Point(427, 30);
            this.lbDataWystawienia.Name = "lbDataWystawienia";
            this.lbDataWystawienia.Size = new System.Drawing.Size(93, 13);
            this.lbDataWystawienia.TabIndex = 28;
            this.lbDataWystawienia.Text = "Data wystawienia:";
            // 
            // tbMiejsceWystawienia
            // 
            this.tbMiejsceWystawienia.Location = new System.Drawing.Point(123, 79);
            this.tbMiejsceWystawienia.Name = "tbMiejsceWystawienia";
            this.tbMiejsceWystawienia.Size = new System.Drawing.Size(276, 20);
            this.tbMiejsceWystawienia.TabIndex = 26;
            // 
            // tbDataWykonaniaUslugi
            // 
            this.tbDataWykonaniaUslugi.Location = new System.Drawing.Point(552, 53);
            this.tbDataWykonaniaUslugi.MaxLength = 8;
            this.tbDataWykonaniaUslugi.Name = "tbDataWykonaniaUslugi";
            this.tbDataWykonaniaUslugi.Size = new System.Drawing.Size(262, 20);
            this.tbDataWykonaniaUslugi.TabIndex = 24;
            this.tbDataWykonaniaUslugi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDataWykonaniaUslugi_KeyPress);
            this.tbDataWykonaniaUslugi.Validating += new System.ComponentModel.CancelEventHandler(this.tbDataWykonaniaUslugi_Validating);
            // 
            // tbDataWystawienia
            // 
            this.tbDataWystawienia.Location = new System.Drawing.Point(552, 27);
            this.tbDataWystawienia.MaxLength = 8;
            this.tbDataWystawienia.Name = "tbDataWystawienia";
            this.tbDataWystawienia.Size = new System.Drawing.Size(262, 20);
            this.tbDataWystawienia.TabIndex = 23;
            this.tbDataWystawienia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDataWystawienia_KeyPress);
            this.tbDataWystawienia.Validating += new System.ComponentModel.CancelEventHandler(this.tbDataWystawienia_Validating);
            // 
            // lbNrFaktury
            // 
            this.lbNrFaktury.AutoSize = true;
            this.lbNrFaktury.Location = new System.Drawing.Point(12, 30);
            this.lbNrFaktury.Name = "lbNrFaktury";
            this.lbNrFaktury.Size = new System.Drawing.Size(56, 13);
            this.lbNrFaktury.TabIndex = 19;
            this.lbNrFaktury.Text = "Nr faktury:";
            // 
            // lbTerminZaplaty
            // 
            this.lbTerminZaplaty.AutoSize = true;
            this.lbTerminZaplaty.Location = new System.Drawing.Point(427, 108);
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
            this.usluga,
            this.jm,
            this.ilosc,
            this.cenaJednostkowa,
            this.wartoscNetto,
            this.procentVat,
            this.wartoscVat,
            this.wartoscBrutto});
            this.dataGridView1.Location = new System.Drawing.Point(14, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 233);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
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
            this.jm.Width = 57;
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
            // wartoscNetto
            // 
            this.wartoscNetto.HeaderText = "Wartość Netto";
            this.wartoscNetto.Name = "wartoscNetto";
            // 
            // procentVat
            // 
            this.procentVat.HeaderText = "%VAT";
            this.procentVat.Name = "procentVat";
            this.procentVat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.procentVat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // sTAWKAVATBindingSource
            // 
            this.sTAWKAVATBindingSource.DataMember = "STAWKA_VAT";
            this.sTAWKAVATBindingSource.DataSource = this.bDdataSet;
            // 
            // bDdataSet
            // 
            this.bDdataSet.DataSetName = "DataSetBD";
            this.bDdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOZYCJAFAKTURYBindingSource
            // 
            this.pOZYCJAFAKTURYBindingSource.DataMember = "POZYCJA_FAKTURY";
            this.pOZYCJAFAKTURYBindingSource.DataSource = this.bDdataSet;
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
            this.cbKlient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.lbKlient.Location = new System.Drawing.Point(12, 55);
            this.lbKlient.Name = "lbKlient";
            this.lbKlient.Size = new System.Drawing.Size(36, 13);
            this.lbKlient.TabIndex = 39;
            this.lbKlient.Text = "Klient:";
            // 
            // cbSposobZaplaty
            // 
            this.cbSposobZaplaty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbUzytkownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // sTAWKA_VATTableAdapter
            // 
            this.sTAWKA_VATTableAdapter.ClearBeforeFill = true;
            // 
            // lbSumaNetto
            // 
            this.lbSumaNetto.AutoSize = true;
            this.lbSumaNetto.Location = new System.Drawing.Point(503, 373);
            this.lbSumaNetto.Name = "lbSumaNetto";
            this.lbSumaNetto.Size = new System.Drawing.Size(66, 13);
            this.lbSumaNetto.TabIndex = 47;
            this.lbSumaNetto.Text = "Suma Netto:";
            // 
            // lbSumaVat
            // 
            this.lbSumaVat.AutoSize = true;
            this.lbSumaVat.Location = new System.Drawing.Point(619, 373);
            this.lbSumaVat.Name = "lbSumaVat";
            this.lbSumaVat.Size = new System.Drawing.Size(61, 13);
            this.lbSumaVat.TabIndex = 48;
            this.lbSumaVat.Text = "Suma VAT:";
            // 
            // lbSumaBrutto
            // 
            this.lbSumaBrutto.AutoSize = true;
            this.lbSumaBrutto.Location = new System.Drawing.Point(736, 373);
            this.lbSumaBrutto.Name = "lbSumaBrutto";
            this.lbSumaBrutto.Size = new System.Drawing.Size(68, 13);
            this.lbSumaBrutto.TabIndex = 49;
            this.lbSumaBrutto.Text = "Suma Brutto:";
            // 
            // lbSumaNettoWartosc
            // 
            this.lbSumaNettoWartosc.AutoSize = true;
            this.lbSumaNettoWartosc.Location = new System.Drawing.Point(503, 390);
            this.lbSumaNettoWartosc.Name = "lbSumaNettoWartosc";
            this.lbSumaNettoWartosc.Size = new System.Drawing.Size(13, 13);
            this.lbSumaNettoWartosc.TabIndex = 50;
            this.lbSumaNettoWartosc.Text = "0";
            // 
            // lbSumaVatWartosc
            // 
            this.lbSumaVatWartosc.AutoSize = true;
            this.lbSumaVatWartosc.Location = new System.Drawing.Point(619, 390);
            this.lbSumaVatWartosc.Name = "lbSumaVatWartosc";
            this.lbSumaVatWartosc.Size = new System.Drawing.Size(13, 13);
            this.lbSumaVatWartosc.TabIndex = 51;
            this.lbSumaVatWartosc.Text = "0";
            // 
            // lbSumaBruttoWartosc
            // 
            this.lbSumaBruttoWartosc.AutoSize = true;
            this.lbSumaBruttoWartosc.Location = new System.Drawing.Point(736, 390);
            this.lbSumaBruttoWartosc.Name = "lbSumaBruttoWartosc";
            this.lbSumaBruttoWartosc.Size = new System.Drawing.Size(13, 13);
            this.lbSumaBruttoWartosc.TabIndex = 52;
            this.lbSumaBruttoWartosc.Text = "0";
            // 
            // lbUwagi
            // 
            this.lbUwagi.AutoSize = true;
            this.lbUwagi.Location = new System.Drawing.Point(12, 373);
            this.lbUwagi.Name = "lbUwagi";
            this.lbUwagi.Size = new System.Drawing.Size(40, 13);
            this.lbUwagi.TabIndex = 53;
            this.lbUwagi.Text = "Uwagi:";
            // 
            // tbUwagi
            // 
            this.tbUwagi.Location = new System.Drawing.Point(78, 370);
            this.tbUwagi.Name = "tbUwagi";
            this.tbUwagi.Size = new System.Drawing.Size(320, 20);
            this.tbUwagi.TabIndex = 54;
            // 
            // lbNrFakturyWartosc
            // 
            this.lbNrFakturyWartosc.AutoSize = true;
            this.lbNrFakturyWartosc.Enabled = false;
            this.lbNrFakturyWartosc.Location = new System.Drawing.Point(122, 29);
            this.lbNrFakturyWartosc.Name = "lbNrFakturyWartosc";
            this.lbNrFakturyWartosc.Size = new System.Drawing.Size(13, 13);
            this.lbNrFakturyWartosc.TabIndex = 55;
            this.lbNrFakturyWartosc.Text = "1";
            // 
            // FormNowaFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lbNrFakturyWartosc);
            this.Controls.Add(this.tbUwagi);
            this.Controls.Add(this.lbUwagi);
            this.Controls.Add(this.lbSumaBruttoWartosc);
            this.Controls.Add(this.lbSumaVatWartosc);
            this.Controls.Add(this.lbSumaNettoWartosc);
            this.Controls.Add(this.lbSumaBrutto);
            this.Controls.Add(this.lbSumaVat);
            this.Controls.Add(this.lbSumaNetto);
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
            this.Controls.Add(this.lbMiejsceWystawienia);
            this.Controls.Add(this.lbSposobZaplaty);
            this.Controls.Add(this.lbDataWykonaniaUslugi);
            this.Controls.Add(this.lbDataWystawienia);
            this.Controls.Add(this.tbMiejsceWystawienia);
            this.Controls.Add(this.tbDataWykonaniaUslugi);
            this.Controls.Add(this.tbDataWystawienia);
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
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKAVATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOZYCJAFAKTURYBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lbMiejsceWystawienia;
        private System.Windows.Forms.Label lbSposobZaplaty;
        private System.Windows.Forms.Label lbDataWykonaniaUslugi;
        private System.Windows.Forms.Label lbDataWystawienia;
        private System.Windows.Forms.TextBox tbMiejsceWystawienia;
        private System.Windows.Forms.TextBox tbDataWykonaniaUslugi;
        private System.Windows.Forms.TextBox tbDataWystawienia;
        private System.Windows.Forms.Label lbNrFaktury;
        private System.Windows.Forms.Label lbTerminZaplaty;
        private System.Windows.Forms.TextBox tbTerminZaplaty;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbSporzadzil;
        private BDDataSet bDdataSet;
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
        private System.Windows.Forms.BindingSource sTAWKAVATBindingSource;
        private BDDataSetTableAdapters.STAWKA_VATTableAdapter sTAWKA_VATTableAdapter;
        private System.Windows.Forms.Label lbSumaNetto;
        private System.Windows.Forms.Label lbSumaVat;
        private System.Windows.Forms.Label lbSumaBrutto;
        private System.Windows.Forms.Label lbSumaNettoWartosc;
        private System.Windows.Forms.Label lbSumaVatWartosc;
        private System.Windows.Forms.Label lbSumaBruttoWartosc;
        private System.Windows.Forms.Label lbUwagi;
        private System.Windows.Forms.TextBox tbUwagi;
        private System.Windows.Forms.DataGridViewComboBoxColumn usluga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaJednostkowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscNetto;
        private System.Windows.Forms.DataGridViewComboBoxColumn procentVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscVat;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscBrutto;
        private System.Windows.Forms.Label lbNrFakturyWartosc;
    }
}