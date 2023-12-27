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
            this.dataSetBD = new ProjektBD.DataSetBD();
            this.sTAWKIVATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAWKI_VATTableAdapter = new ProjektBD.DataSetBDTableAdapters.STAWKI_VATTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTAWKAVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCENTVATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTAWKIVATBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKIVATBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKIVATBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pomocToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
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
            // 
            // btnEdytuj
            // 
            resources.ApplyResources(this.btnEdytuj, "btnEdytuj");
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            // 
            // btnUsun
            // 
            resources.ApplyResources(this.btnUsun, "btnUsun");
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.UseVisualStyleBackColor = true;
            // 
            // dataSetBD
            // 
            this.dataSetBD.DataSetName = "DataSetBD";
            this.dataSetBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAWKIVATBindingSource
            // 
            this.sTAWKIVATBindingSource.DataMember = "STAWKI_VAT";
            this.sTAWKIVATBindingSource.DataSource = this.dataSetBD;
            // 
            // sTAWKI_VATTableAdapter
            // 
            this.sTAWKI_VATTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTAWKAVATDataGridViewTextBoxColumn,
            this.pROCENTVATDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTAWKIVATBindingSource1;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            // 
            // sTAWKAVATDataGridViewTextBoxColumn
            // 
            this.sTAWKAVATDataGridViewTextBoxColumn.DataPropertyName = "STAWKA_VAT";
            resources.ApplyResources(this.sTAWKAVATDataGridViewTextBoxColumn, "sTAWKAVATDataGridViewTextBoxColumn");
            this.sTAWKAVATDataGridViewTextBoxColumn.Name = "sTAWKAVATDataGridViewTextBoxColumn";
            this.sTAWKAVATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pROCENTVATDataGridViewTextBoxColumn
            // 
            this.pROCENTVATDataGridViewTextBoxColumn.DataPropertyName = "PROCENT_VAT";
            resources.ApplyResources(this.pROCENTVATDataGridViewTextBoxColumn, "pROCENTVATDataGridViewTextBoxColumn");
            this.pROCENTVATDataGridViewTextBoxColumn.Name = "pROCENTVATDataGridViewTextBoxColumn";
            this.pROCENTVATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTAWKIVATBindingSource1
            // 
            this.sTAWKIVATBindingSource1.DataMember = "STAWKI_VAT";
            this.sTAWKIVATBindingSource1.DataSource = this.dataSetBD;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKIVATBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAWKIVATBindingSource1)).EndInit();
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
        private DataSetBD dataSetBD;
        private System.Windows.Forms.BindingSource sTAWKIVATBindingSource;
        private DataSetBDTableAdapters.STAWKI_VATTableAdapter sTAWKI_VATTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTAWKAVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCENTVATDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTAWKIVATBindingSource1;
    }
}