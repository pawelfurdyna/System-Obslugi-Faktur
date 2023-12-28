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
            this.tbSposobZaplaty = new System.Windows.Forms.TextBox();
            this.tbDataWykonaniaUslugi = new System.Windows.Forms.TextBox();
            this.tbDataWystawienia = new System.Windows.Forms.TextBox();
            this.tbNipKlienta = new System.Windows.Forms.TextBox();
            this.lbNipKlienta = new System.Windows.Forms.Label();
            this.tbNrFaktury = new System.Windows.Forms.TextBox();
            this.lbNrFaktury = new System.Windows.Forms.Label();
            this.lbTerminZaplaty = new System.Windows.Forms.Label();
            this.tbTerminZaplaty = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbSporzadzil = new System.Windows.Forms.Label();
            this.tbSporzadzil = new System.Windows.Forms.TextBox();
            this.dataSetBD = new ProjektBD.DataSetBD();
            this.pOZYCJAFAKTURYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOZYCJA_FAKTURYTableAdapter = new ProjektBD.DataSetBDTableAdapters.POZYCJA_FAKTURYTableAdapter();
            this.iDPOZYCJIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERFAKTURYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUSLUGIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAWKAVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iLOSCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wARTOSCNETTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wARTOSCVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOZYCJAFAKTURYBindingSource)).BeginInit();
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
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.lbAdresKlienta.Location = new System.Drawing.Point(12, 86);
            this.lbAdresKlienta.Name = "lbAdresKlienta";
            this.lbAdresKlienta.Size = new System.Drawing.Size(71, 13);
            this.lbAdresKlienta.TabIndex = 32;
            this.lbAdresKlienta.Text = "Adres klienta:";
            // 
            // lbMiejsceWystawienia
            // 
            this.lbMiejsceWystawienia.AutoSize = true;
            this.lbMiejsceWystawienia.Location = new System.Drawing.Point(11, 112);
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
            this.tbAdresKlienta.Location = new System.Drawing.Point(122, 79);
            this.tbAdresKlienta.Name = "tbAdresKlienta";
            this.tbAdresKlienta.Size = new System.Drawing.Size(276, 20);
            this.tbAdresKlienta.TabIndex = 27;
            // 
            // tbMiejsceWystawienia
            // 
            this.tbMiejsceWystawienia.Location = new System.Drawing.Point(122, 105);
            this.tbMiejsceWystawienia.Name = "tbMiejsceWystawienia";
            this.tbMiejsceWystawienia.Size = new System.Drawing.Size(276, 20);
            this.tbMiejsceWystawienia.TabIndex = 26;
            // 
            // tbSposobZaplaty
            // 
            this.tbSposobZaplaty.Location = new System.Drawing.Point(552, 79);
            this.tbSposobZaplaty.Name = "tbSposobZaplaty";
            this.tbSposobZaplaty.Size = new System.Drawing.Size(262, 20);
            this.tbSposobZaplaty.TabIndex = 25;
            // 
            // tbDataWykonaniaUslugi
            // 
            this.tbDataWykonaniaUslugi.Location = new System.Drawing.Point(552, 53);
            this.tbDataWykonaniaUslugi.Name = "tbDataWykonaniaUslugi";
            this.tbDataWykonaniaUslugi.Size = new System.Drawing.Size(262, 20);
            this.tbDataWykonaniaUslugi.TabIndex = 24;
            // 
            // tbDataWystawienia
            // 
            this.tbDataWystawienia.Location = new System.Drawing.Point(552, 27);
            this.tbDataWystawienia.Name = "tbDataWystawienia";
            this.tbDataWystawienia.Size = new System.Drawing.Size(262, 20);
            this.tbDataWystawienia.TabIndex = 23;
            // 
            // tbNipKlienta
            // 
            this.tbNipKlienta.Location = new System.Drawing.Point(122, 53);
            this.tbNipKlienta.Name = "tbNipKlienta";
            this.tbNipKlienta.Size = new System.Drawing.Size(276, 20);
            this.tbNipKlienta.TabIndex = 22;
            // 
            // lbNipKlienta
            // 
            this.lbNipKlienta.AutoSize = true;
            this.lbNipKlienta.Location = new System.Drawing.Point(12, 60);
            this.lbNipKlienta.Name = "lbNipKlienta";
            this.lbNipKlienta.Size = new System.Drawing.Size(62, 13);
            this.lbNipKlienta.TabIndex = 21;
            this.lbNipKlienta.Text = "NIP klienta:";
            // 
            // tbNrFaktury
            // 
            this.tbNrFaktury.Location = new System.Drawing.Point(122, 27);
            this.tbNrFaktury.Name = "tbNrFaktury";
            this.tbNrFaktury.Size = new System.Drawing.Size(276, 20);
            this.tbNrFaktury.TabIndex = 20;
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
            this.lbTerminZaplaty.Size = new System.Drawing.Size(80, 13);
            this.lbTerminZaplaty.TabIndex = 34;
            this.lbTerminZaplaty.Text = "Termin zapłaty:";
            // 
            // tbTerminZaplaty
            // 
            this.tbTerminZaplaty.Location = new System.Drawing.Point(552, 105);
            this.tbTerminZaplaty.Name = "tbTerminZaplaty";
            this.tbTerminZaplaty.Size = new System.Drawing.Size(262, 20);
            this.tbTerminZaplaty.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPOZYCJIDataGridViewTextBoxColumn,
            this.nUMERFAKTURYDataGridViewTextBoxColumn,
            this.iDUSLUGIDataGridViewTextBoxColumn,
            this.sTAWKAVATDataGridViewTextBoxColumn,
            this.iLOSCDataGridViewTextBoxColumn,
            this.wARTOSCNETTODataGridViewTextBoxColumn,
            this.wARTOSCVATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pOZYCJAFAKTURYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 227);
            this.dataGridView1.TabIndex = 35;
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
            // tbSporzadzil
            // 
            this.tbSporzadzil.Location = new System.Drawing.Point(102, 392);
            this.tbSporzadzil.Name = "tbSporzadzil";
            this.tbSporzadzil.Size = new System.Drawing.Size(296, 20);
            this.tbSporzadzil.TabIndex = 36;
            // 
            // dataSetBD
            // 
            this.dataSetBD.DataSetName = "DataSetBD";
            this.dataSetBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOZYCJAFAKTURYBindingSource
            // 
            this.pOZYCJAFAKTURYBindingSource.DataMember = "POZYCJA_FAKTURY";
            this.pOZYCJAFAKTURYBindingSource.DataSource = this.dataSetBD;
            // 
            // pOZYCJA_FAKTURYTableAdapter
            // 
            this.pOZYCJA_FAKTURYTableAdapter.ClearBeforeFill = true;
            // 
            // iDPOZYCJIDataGridViewTextBoxColumn
            // 
            this.iDPOZYCJIDataGridViewTextBoxColumn.DataPropertyName = "ID_POZYCJI";
            this.iDPOZYCJIDataGridViewTextBoxColumn.HeaderText = "ID_POZYCJI";
            this.iDPOZYCJIDataGridViewTextBoxColumn.Name = "iDPOZYCJIDataGridViewTextBoxColumn";
            // 
            // nUMERFAKTURYDataGridViewTextBoxColumn
            // 
            this.nUMERFAKTURYDataGridViewTextBoxColumn.DataPropertyName = "NUMER_FAKTURY";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.HeaderText = "NUMER_FAKTURY";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.Name = "nUMERFAKTURYDataGridViewTextBoxColumn";
            // 
            // iDUSLUGIDataGridViewTextBoxColumn
            // 
            this.iDUSLUGIDataGridViewTextBoxColumn.DataPropertyName = "ID_USLUGI";
            this.iDUSLUGIDataGridViewTextBoxColumn.HeaderText = "ID_USLUGI";
            this.iDUSLUGIDataGridViewTextBoxColumn.Name = "iDUSLUGIDataGridViewTextBoxColumn";
            // 
            // sTAWKAVATDataGridViewTextBoxColumn
            // 
            this.sTAWKAVATDataGridViewTextBoxColumn.DataPropertyName = "STAWKA_VAT";
            this.sTAWKAVATDataGridViewTextBoxColumn.HeaderText = "STAWKA_VAT";
            this.sTAWKAVATDataGridViewTextBoxColumn.Name = "sTAWKAVATDataGridViewTextBoxColumn";
            // 
            // iLOSCDataGridViewTextBoxColumn
            // 
            this.iLOSCDataGridViewTextBoxColumn.DataPropertyName = "ILOSC";
            this.iLOSCDataGridViewTextBoxColumn.HeaderText = "ILOSC";
            this.iLOSCDataGridViewTextBoxColumn.Name = "iLOSCDataGridViewTextBoxColumn";
            // 
            // wARTOSCNETTODataGridViewTextBoxColumn
            // 
            this.wARTOSCNETTODataGridViewTextBoxColumn.DataPropertyName = "WARTOSC_NETTO";
            this.wARTOSCNETTODataGridViewTextBoxColumn.HeaderText = "WARTOSC_NETTO";
            this.wARTOSCNETTODataGridViewTextBoxColumn.Name = "wARTOSCNETTODataGridViewTextBoxColumn";
            // 
            // wARTOSCVATDataGridViewTextBoxColumn
            // 
            this.wARTOSCVATDataGridViewTextBoxColumn.DataPropertyName = "WARTOSC_VAT";
            this.wARTOSCVATDataGridViewTextBoxColumn.HeaderText = "WARTOSC_VAT";
            this.wARTOSCVATDataGridViewTextBoxColumn.Name = "wARTOSCVATDataGridViewTextBoxColumn";
            // 
            // FormNowaFaktura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.lbSporzadzil);
            this.Controls.Add(this.tbSporzadzil);
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
            this.Controls.Add(this.tbSposobZaplaty);
            this.Controls.Add(this.tbDataWykonaniaUslugi);
            this.Controls.Add(this.tbDataWystawienia);
            this.Controls.Add(this.tbNipKlienta);
            this.Controls.Add(this.lbNipKlienta);
            this.Controls.Add(this.tbNrFaktury);
            this.Controls.Add(this.lbNrFaktury);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNowaFaktura";
            this.Text = "Nowa Faktura";
            this.Load += new System.EventHandler(this.FormNowaFaktura_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOZYCJAFAKTURYBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox tbSposobZaplaty;
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
        private System.Windows.Forms.TextBox tbSporzadzil;
        private DataSetBD dataSetBD;
        private System.Windows.Forms.BindingSource pOZYCJAFAKTURYBindingSource;
        private DataSetBDTableAdapters.POZYCJA_FAKTURYTableAdapter pOZYCJA_FAKTURYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPOZYCJIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERFAKTURYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSLUGIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAWKAVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iLOSCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wARTOSCNETTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wARTOSCVATDataGridViewTextBoxColumn;
    }
}