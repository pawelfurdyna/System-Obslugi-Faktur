namespace ProjektBD
{
    partial class FormUslugiLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUslugiLista));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uSLUGIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBD = new ProjektBD.DataSetBD();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.uSLUGITableAdapter = new ProjektBD.DataSetBDTableAdapters.USLUGITableAdapter();
            this.iDUSLUGIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAZWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSLUGIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBD)).BeginInit();
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
            this.iDUSLUGIDataGridViewTextBoxColumn,
            this.nAZWADataGridViewTextBoxColumn,
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn,
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uSLUGIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 338);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // uSLUGIBindingSource
            // 
            this.uSLUGIBindingSource.DataMember = "USLUGI";
            this.uSLUGIBindingSource.DataSource = this.dataSetBD;
            // 
            // dataSetBD
            // 
            this.dataSetBD.DataSetName = "DataSetBD";
            this.dataSetBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // 
            // uSLUGITableAdapter
            // 
            this.uSLUGITableAdapter.ClearBeforeFill = true;
            // 
            // iDUSLUGIDataGridViewTextBoxColumn
            // 
            this.iDUSLUGIDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDUSLUGIDataGridViewTextBoxColumn.DataPropertyName = "ID_USLUGI";
            this.iDUSLUGIDataGridViewTextBoxColumn.HeaderText = "ID_USLUGI";
            this.iDUSLUGIDataGridViewTextBoxColumn.Name = "iDUSLUGIDataGridViewTextBoxColumn";
            this.iDUSLUGIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUSLUGIDataGridViewTextBoxColumn.Width = 89;
            // 
            // nAZWADataGridViewTextBoxColumn
            // 
            this.nAZWADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nAZWADataGridViewTextBoxColumn.DataPropertyName = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.HeaderText = "NAZWA";
            this.nAZWADataGridViewTextBoxColumn.Name = "nAZWADataGridViewTextBoxColumn";
            this.nAZWADataGridViewTextBoxColumn.ReadOnly = true;
            this.nAZWADataGridViewTextBoxColumn.Width = 72;
            // 
            // cENAJEDNOSTKOWADataGridViewTextBoxColumn
            // 
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn.DataPropertyName = "CENA_JEDNOSTKOWA";
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn.HeaderText = "CENA_JEDNOSTKOWA";
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn.Name = "cENAJEDNOSTKOWADataGridViewTextBoxColumn";
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn.ReadOnly = true;
            this.cENAJEDNOSTKOWADataGridViewTextBoxColumn.Width = 150;
            // 
            // jEDNOSTKAMIARYDataGridViewTextBoxColumn
            // 
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn.DataPropertyName = "JEDNOSTKA_MIARY";
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn.HeaderText = "JEDNOSTKA_MIARY";
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn.Name = "jEDNOSTKAMIARYDataGridViewTextBoxColumn";
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn.ReadOnly = true;
            this.jEDNOSTKAMIARYDataGridViewTextBoxColumn.Width = 136;
            // 
            // FormUslugiLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUslugiLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Uslugi";
            this.Load += new System.EventHandler(this.FormUslugiLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSLUGIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBD)).EndInit();
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
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnDodaj;
        private DataSetBD dataSetBD;
        private System.Windows.Forms.BindingSource uSLUGIBindingSource;
        private DataSetBDTableAdapters.USLUGITableAdapter uSLUGITableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUSLUGIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAZWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cENAJEDNOSTKOWADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jEDNOSTKAMIARYDataGridViewTextBoxColumn;
    }
}