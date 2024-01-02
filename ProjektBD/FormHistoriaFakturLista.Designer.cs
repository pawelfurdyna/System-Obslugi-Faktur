namespace ProjektBD
{
    partial class FormHistoriaFakturLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHistoriaFakturLista));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nUMERFAKTURYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWYKONANIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uWAGIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tERMINZAPLATYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKLIENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAKTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSetFaktura = new ProjektBD.BDDataSetFaktura();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.fAKTURATableAdapter = new ProjektBD.BDDataSetFakturaTableAdapters.FAKTURATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAKTURABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetFaktura)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nUMERFAKTURYDataGridViewTextBoxColumn,
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn,
            this.dATAWYKONANIADataGridViewTextBoxColumn,
            this.uWAGIDataGridViewTextBoxColumn,
            this.tERMINZAPLATYDataGridViewTextBoxColumn,
            this.iDKLIENTADataGridViewTextBoxColumn,
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fAKTURABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 338);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Sorted += new System.EventHandler(this.dataGridView1_Sorted);
            // 
            // nUMERFAKTURYDataGridViewTextBoxColumn
            // 
            this.nUMERFAKTURYDataGridViewTextBoxColumn.DataPropertyName = "NUMER_FAKTURY";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.HeaderText = "Nr faktury";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.Name = "nUMERFAKTURYDataGridViewTextBoxColumn";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAWYSTAWIENIADataGridViewTextBoxColumn
            // 
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.DataPropertyName = "DATA_WYSTAWIENIA";
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.HeaderText = "Data wystawienia";
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.Name = "dATAWYSTAWIENIADataGridViewTextBoxColumn";
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAWYKONANIADataGridViewTextBoxColumn
            // 
            this.dATAWYKONANIADataGridViewTextBoxColumn.DataPropertyName = "DATA_WYKONANIA";
            this.dATAWYKONANIADataGridViewTextBoxColumn.HeaderText = "Data wykonania";
            this.dATAWYKONANIADataGridViewTextBoxColumn.Name = "dATAWYKONANIADataGridViewTextBoxColumn";
            this.dATAWYKONANIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uWAGIDataGridViewTextBoxColumn
            // 
            this.uWAGIDataGridViewTextBoxColumn.DataPropertyName = "UWAGI";
            this.uWAGIDataGridViewTextBoxColumn.HeaderText = "Uwagi";
            this.uWAGIDataGridViewTextBoxColumn.Name = "uWAGIDataGridViewTextBoxColumn";
            this.uWAGIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tERMINZAPLATYDataGridViewTextBoxColumn
            // 
            this.tERMINZAPLATYDataGridViewTextBoxColumn.DataPropertyName = "TERMIN_ZAPLATY";
            this.tERMINZAPLATYDataGridViewTextBoxColumn.HeaderText = "Termin zaplaty(dni)";
            this.tERMINZAPLATYDataGridViewTextBoxColumn.Name = "tERMINZAPLATYDataGridViewTextBoxColumn";
            this.tERMINZAPLATYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKLIENTADataGridViewTextBoxColumn
            // 
            this.iDKLIENTADataGridViewTextBoxColumn.DataPropertyName = "ID_KLIENTA";
            this.iDKLIENTADataGridViewTextBoxColumn.HeaderText = "Id Klienta";
            this.iDKLIENTADataGridViewTextBoxColumn.Name = "iDKLIENTADataGridViewTextBoxColumn";
            this.iDKLIENTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUZYTKOWNIKADataGridViewTextBoxColumn
            // 
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.DataPropertyName = "ID_UZYTKOWNIKA";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.HeaderText = "Id Użytkownika";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.Name = "iDUZYTKOWNIKADataGridViewTextBoxColumn";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fAKTURABindingSource
            // 
            this.fAKTURABindingSource.DataMember = "FAKTURA";
            this.fAKTURABindingSource.DataSource = this.bDDataSetFaktura;
            // 
            // bDDataSetFaktura
            // 
            this.bDDataSetFaktura.DataSetName = "BDDataSetFaktura";
            this.bDDataSetFaktura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 16;
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
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(943, 385);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(112, 23);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj nową fakturę";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // fAKTURATableAdapter
            // 
            this.fAKTURATableAdapter.ClearBeforeFill = true;
            // 
            // FormHistoriaFakturLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(1083, 459);
            this.MinimumSize = new System.Drawing.Size(1083, 459);
            this.Name = "FormHistoriaFakturLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Faktur";
            this.Activated += new System.EventHandler(this.FormHistoriaFakturLista_Activated);
            this.Load += new System.EventHandler(this.FormHistoriaFakturLista_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHistoriaFakturLista_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAKTURABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetFaktura)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Button btnDodaj;
        private BDDataSetFaktura bDDataSetFaktura;
        private System.Windows.Forms.BindingSource fAKTURABindingSource;
        private BDDataSetFakturaTableAdapters.FAKTURATableAdapter fAKTURATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERFAKTURYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAWYSTAWIENIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATAWYKONANIADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uWAGIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tERMINZAPLATYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUZYTKOWNIKADataGridViewTextBoxColumn;
    }
}