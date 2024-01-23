namespace ProjektBD
{
    partial class FormStawkaVAT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStawkaVAT));
            this.lbNazwa = new System.Windows.Forms.Label();
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.tbProcentVAT = new System.Windows.Forms.TextBox();
            this.lbProcentVAT = new System.Windows.Forms.Label();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNazwa
            // 
            this.lbNazwa.AutoSize = true;
            this.lbNazwa.Location = new System.Drawing.Point(13, 13);
            this.lbNazwa.Name = "lbNazwa";
            this.lbNazwa.Size = new System.Drawing.Size(43, 13);
            this.lbNazwa.TabIndex = 0;
            this.lbNazwa.Text = "Nazwa:";
            // 
            // tbNazwa
            // 
            this.tbNazwa.Location = new System.Drawing.Point(95, 6);
            this.tbNazwa.MaxLength = 255;
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(100, 20);
            this.tbNazwa.TabIndex = 1;
            // 
            // tbProcentVAT
            // 
            this.tbProcentVAT.Location = new System.Drawing.Point(95, 32);
            this.tbProcentVAT.MaxLength = 4;
            this.tbProcentVAT.Name = "tbProcentVAT";
            this.tbProcentVAT.Size = new System.Drawing.Size(100, 20);
            this.tbProcentVAT.TabIndex = 3;
            this.tbProcentVAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProcentVAT_KeyPress);
            this.tbProcentVAT.Leave += new System.EventHandler(this.tbProcentVAT_Leave);
            // 
            // lbProcentVAT
            // 
            this.lbProcentVAT.AutoSize = true;
            this.lbProcentVAT.Location = new System.Drawing.Point(13, 39);
            this.lbProcentVAT.Name = "lbProcentVAT";
            this.lbProcentVAT.Size = new System.Drawing.Size(71, 13);
            this.lbProcentVAT.TabIndex = 2;
            this.lbProcentVAT.Text = "Procent VAT:";
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(13, 63);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 4;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(117, 63);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 5;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // FormStawkaVAT
            // 
            this.AcceptButton = this.btnZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(204, 98);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.tbProcentVAT);
            this.Controls.Add(this.lbProcentVAT);
            this.Controls.Add(this.tbNazwa);
            this.Controls.Add(this.lbNazwa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(220, 100);
            this.Name = "FormStawkaVAT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stawka VAT";
            this.Load += new System.EventHandler(this.FormStawkaVAT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNazwa;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.TextBox tbProcentVAT;
        private System.Windows.Forms.Label lbProcentVAT;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}