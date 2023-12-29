namespace ProjektBD
{
    partial class FormKlientLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKlientLista));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.iDKLIENTADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMERTELEFONUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tERMINPLATNOSCIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDdataSet = new ProjektBD.BDDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.kLIENTTableAdapter = new ProjektBD.BDDataSetTableAdapters.KLIENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDKLIENTADataGridViewTextBoxColumn,
            this.nAZWADataGridViewTextBoxColumn,
            this.aDRESDataGridViewTextBoxColumn,
            this.nIPDataGridViewTextBoxColumn,
            this.nUMERTELEFONUDataGridViewTextBoxColumn,
            this.eMAILDataGridViewTextBoxColumn,
            this.tERMINPLATNOSCIDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.kLIENTBindingSource;
            this.dgvData.Location = new System.Drawing.Point(12, 27);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(776, 342);
            this.dgvData.TabIndex = 0;
            // 
            // iDKLIENTADataGridViewTextBoxColumn
            // 
            this.iDKLIENTADataGridViewTextBoxColumn.DataPropertyName = "ID_KLIENTA";
            this.iDKLIENTADataGridViewTextBoxColumn.HeaderText = "ID_KLIENTA";
            this.iDKLIENTADataGridViewTextBoxColumn.Name = "iDKLIENTADataGridViewTextBoxColumn";
            this.iDKLIENTADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            this.nAZWADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDRESDataGridViewTextBoxColumn
            // 
            this.aDRESDataGridViewTextBoxColumn.DataPropertyName = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.HeaderText = "ADRES";
            this.aDRESDataGridViewTextBoxColumn.Name = "aDRESDataGridViewTextBoxColumn";
            this.aDRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            this.nIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nUMERTELEFONUDataGridViewTextBoxColumn
            // 
            this.nUMERTELEFONUDataGridViewTextBoxColumn.DataPropertyName = "NUMER_TELEFONU";
            this.nUMERTELEFONUDataGridViewTextBoxColumn.HeaderText = "NUMER_TELEFONU";
            this.nUMERTELEFONUDataGridViewTextBoxColumn.Name = "nUMERTELEFONUDataGridViewTextBoxColumn";
            this.nUMERTELEFONUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMAILDataGridViewTextBoxColumn
            // 
            this.eMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.eMAILDataGridViewTextBoxColumn.Name = "eMAILDataGridViewTextBoxColumn";
            this.eMAILDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tERMINPLATNOSCIDataGridViewTextBoxColumn
            // 
            this.tERMINPLATNOSCIDataGridViewTextBoxColumn.DataPropertyName = "TERMIN_PLATNOSCI";
            this.tERMINPLATNOSCIDataGridViewTextBoxColumn.HeaderText = "TERMIN_PLATNOSCI";
            this.tERMINPLATNOSCIDataGridViewTextBoxColumn.Name = "tERMINPLATNOSCIDataGridViewTextBoxColumn";
            this.tERMINPLATNOSCIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kLIENTBindingSource
            // 
            this.kLIENTBindingSource.DataMember = "KLIENT";
            this.kLIENTBindingSource.DataSource = this.bDdataSet;
            // 
            // bDdataSet
            // 
            this.bDdataSet.DataSetName = "DataSetBD";
            this.bDdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.btnDodaj.Location = new System.Drawing.Point(551, 376);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Location = new System.Drawing.Point(632, 376);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(75, 23);
            this.btnEdytuj.TabIndex = 11;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(713, 375);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 12;
            this.btnUsun.Text = "Usun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // kLIENTTableAdapter
            // 
            this.kLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // FormKlientLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 415);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormKlientLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klienci";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private BDDataSet bDdataSet;
        private System.Windows.Forms.BindingSource kLIENTBindingSource;
        private BDDataSetTableAdapters.KLIENTTableAdapter kLIENTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKLIENTADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMERTELEFONUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tERMINPLATNOSCIDataGridViewTextBoxColumn;
    }
}