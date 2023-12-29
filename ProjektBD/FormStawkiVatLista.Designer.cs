namespace ProjektBD
{
    partial class FormStawkiVatLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStawkiVatLista));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.bDdataSet = new ProjektBD.BDDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCENTVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAWKAVATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAWKA_VATTableAdapter = new ProjektBD.BDDataSetTableAdapters.STAWKA_VATTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKAVATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            resources.ApplyResources(this.plikToolStripMenuItem, "plikToolStripMenuItem");
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            resources.ApplyResources(this.zakończToolStripMenuItem, "zakończToolStripMenuItem");
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            resources.ApplyResources(this.pomocToolStripMenuItem, "pomocToolStripMenuItem");
            // 
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            resources.ApplyResources(this.btnEdytuj, "btnEdytuj");
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            resources.ApplyResources(this.btnUsun, "btnUsun");
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // bDdataSet
            // 
            this.bDdataSet.DataSetName = "DataSetBD";
            this.bDdataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDVATDataGridViewTextBoxColumn,
            this.pROCENTVATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTAWKAVATBindingSource;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDVATDataGridViewTextBoxColumn
            // 
            this.iDVATDataGridViewTextBoxColumn.DataPropertyName = "ID_VAT";
            resources.ApplyResources(this.iDVATDataGridViewTextBoxColumn, "iDVATDataGridViewTextBoxColumn");
            this.iDVATDataGridViewTextBoxColumn.Name = "iDVATDataGridViewTextBoxColumn";
            this.iDVATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROCENTVATDataGridViewTextBoxColumn
            // 
            this.pROCENTVATDataGridViewTextBoxColumn.DataPropertyName = "PROCENT_VAT";
            resources.ApplyResources(this.pROCENTVATDataGridViewTextBoxColumn, "pROCENTVATDataGridViewTextBoxColumn");
            this.pROCENTVATDataGridViewTextBoxColumn.Name = "pROCENTVATDataGridViewTextBoxColumn";
            this.pROCENTVATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTAWKAVATBindingSource
            // 
            this.sTAWKAVATBindingSource.DataMember = "STAWKA_VAT";
            this.sTAWKAVATBindingSource.DataSource = this.bDdataSet;
            // 
            // sTAWKA_VATTableAdapter
            // 
            this.sTAWKA_VATTableAdapter.ClearBeforeFill = true;
            // 
            // FormStawkiVatLista
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStawkiVatLista";
            this.Load += new System.EventHandler(this.FormStawkiVatLista_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDdataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKAVATBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private BDDataSet bDdataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sTAWKAVATBindingSource;
        private BDDataSetTableAdapters.STAWKA_VATTableAdapter sTAWKA_VATTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCENTVATDataGridViewTextBoxColumn;
    }
}