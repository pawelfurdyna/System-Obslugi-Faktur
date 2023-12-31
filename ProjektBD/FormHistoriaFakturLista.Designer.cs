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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.bDDataSetFaktura = new ProjektBD.BDDataSetFaktura();
            this.bDDataSetFakturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAKTURABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAKTURATableAdapter = new ProjektBD.BDDataSetFakturaTableAdapters.FAKTURATableAdapter();
            this.nUMERFAKTURYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATAWYKONANIADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uWAGIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tERMINZAPLATYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDKLIENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetFaktura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetFakturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAKTURABindingSource)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(776, 338);
            this.dataGridView1.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(712, 385);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 19;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(631, 385);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 18;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(550, 385);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // bDDataSetFaktura
            // 
            this.bDDataSetFaktura.DataSetName = "BDDataSetFaktura";
            this.bDDataSetFaktura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDDataSetFakturaBindingSource
            // 
            this.bDDataSetFakturaBindingSource.DataSource = this.bDDataSetFaktura;
            this.bDDataSetFakturaBindingSource.Position = 0;
            // 
            // fAKTURABindingSource
            // 
            this.fAKTURABindingSource.DataMember = "FAKTURA";
            this.fAKTURABindingSource.DataSource = this.bDDataSetFakturaBindingSource;
            // 
            // fAKTURATableAdapter
            // 
            this.fAKTURATableAdapter.ClearBeforeFill = true;
            // 
            // nUMERFAKTURYDataGridViewTextBoxColumn
            // 
            this.nUMERFAKTURYDataGridViewTextBoxColumn.DataPropertyName = "NUMER_FAKTURY";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.HeaderText = "NUMER_FAKTURY";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.Name = "nUMERFAKTURYDataGridViewTextBoxColumn";
            this.nUMERFAKTURYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAWYSTAWIENIADataGridViewTextBoxColumn
            // 
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.DataPropertyName = "DATA_WYSTAWIENIA";
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.HeaderText = "DATA_WYSTAWIENIA";
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.Name = "dATAWYSTAWIENIADataGridViewTextBoxColumn";
            this.dATAWYSTAWIENIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATAWYKONANIADataGridViewTextBoxColumn
            // 
            this.dATAWYKONANIADataGridViewTextBoxColumn.DataPropertyName = "DATA_WYKONANIA";
            this.dATAWYKONANIADataGridViewTextBoxColumn.HeaderText = "DATA_WYKONANIA";
            this.dATAWYKONANIADataGridViewTextBoxColumn.Name = "dATAWYKONANIADataGridViewTextBoxColumn";
            this.dATAWYKONANIADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uWAGIDataGridViewTextBoxColumn
            // 
            this.uWAGIDataGridViewTextBoxColumn.DataPropertyName = "UWAGI";
            this.uWAGIDataGridViewTextBoxColumn.HeaderText = "UWAGI";
            this.uWAGIDataGridViewTextBoxColumn.Name = "uWAGIDataGridViewTextBoxColumn";
            this.uWAGIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tERMINZAPLATYDataGridViewTextBoxColumn
            // 
            this.tERMINZAPLATYDataGridViewTextBoxColumn.DataPropertyName = "TERMIN_ZAPLATY";
            this.tERMINZAPLATYDataGridViewTextBoxColumn.HeaderText = "TERMIN_ZAPLATY";
            this.tERMINZAPLATYDataGridViewTextBoxColumn.Name = "tERMINZAPLATYDataGridViewTextBoxColumn";
            this.tERMINZAPLATYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDKLIENTADataGridViewTextBoxColumn
            // 
            this.iDKLIENTADataGridViewTextBoxColumn.DataPropertyName = "ID_KLIENTA";
            this.iDKLIENTADataGridViewTextBoxColumn.HeaderText = "ID_KLIENTA";
            this.iDKLIENTADataGridViewTextBoxColumn.Name = "iDKLIENTADataGridViewTextBoxColumn";
            this.iDKLIENTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDUZYTKOWNIKADataGridViewTextBoxColumn
            // 
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.DataPropertyName = "ID_UZYTKOWNIKA";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.HeaderText = "ID_UZYTKOWNIKA";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.Name = "iDUZYTKOWNIKADataGridViewTextBoxColumn";
            this.iDUZYTKOWNIKADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormHistoriaFakturLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHistoriaFakturLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historia Faktur";
            this.Load += new System.EventHandler(this.FormHistoriaFakturLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetFaktura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSetFakturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAKTURABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.BindingSource bDDataSetFakturaBindingSource;
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