namespace ProjektBD
{
    partial class FormUsluga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsluga));
            this.tbJednostkaMiary = new System.Windows.Forms.TextBox();
            this.lbJednostkaMiary = new System.Windows.Forms.Label();
            this.tbCenaJednostkowa = new System.Windows.Forms.TextBox();
            this.lbCenaJednostkowa = new System.Windows.Forms.Label();
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.lbNazwa = new System.Windows.Forms.Label();
            this.tbIdUslugi = new System.Windows.Forms.TextBox();
            this.lbIdUslugi = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbJednostkaMiary
            // 
            this.tbJednostkaMiary.Location = new System.Drawing.Point(108, 94);
            this.tbJednostkaMiary.MaxLength = 255;
            this.tbJednostkaMiary.Name = "tbJednostkaMiary";
            this.tbJednostkaMiary.Size = new System.Drawing.Size(100, 20);
            this.tbJednostkaMiary.TabIndex = 15;
            // 
            // lbJednostkaMiary
            // 
            this.lbJednostkaMiary.AutoSize = true;
            this.lbJednostkaMiary.Location = new System.Drawing.Point(10, 97);
            this.lbJednostkaMiary.Name = "lbJednostkaMiary";
            this.lbJednostkaMiary.Size = new System.Drawing.Size(86, 13);
            this.lbJednostkaMiary.TabIndex = 14;
            this.lbJednostkaMiary.Text = "Jednostka miary:";
            // 
            // tbCenaJednostkowa
            // 
            this.tbCenaJednostkowa.Location = new System.Drawing.Point(108, 68);
            this.tbCenaJednostkowa.Name = "tbCenaJednostkowa";
            this.tbCenaJednostkowa.Size = new System.Drawing.Size(100, 20);
            this.tbCenaJednostkowa.TabIndex = 13;
            this.tbCenaJednostkowa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCenaJednostkowa_KeyPress);
            this.tbCenaJednostkowa.Leave += new System.EventHandler(this.tbCenaJednostkowa_Leave);
            // 
            // lbCenaJednostkowa
            // 
            this.lbCenaJednostkowa.AutoSize = true;
            this.lbCenaJednostkowa.Location = new System.Drawing.Point(10, 71);
            this.lbCenaJednostkowa.Name = "lbCenaJednostkowa";
            this.lbCenaJednostkowa.Size = new System.Drawing.Size(98, 13);
            this.lbCenaJednostkowa.TabIndex = 12;
            this.lbCenaJednostkowa.Text = "Cena jednostkowa:";
            // 
            // tbNazwa
            // 
            this.tbNazwa.Location = new System.Drawing.Point(108, 42);
            this.tbNazwa.MaxLength = 255;
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(100, 20);
            this.tbNazwa.TabIndex = 11;
            // 
            // lbNazwa
            // 
            this.lbNazwa.AutoSize = true;
            this.lbNazwa.Location = new System.Drawing.Point(10, 45);
            this.lbNazwa.Name = "lbNazwa";
            this.lbNazwa.Size = new System.Drawing.Size(43, 13);
            this.lbNazwa.TabIndex = 10;
            this.lbNazwa.Text = "Nazwa:";
            // 
            // tbIdUslugi
            // 
            this.tbIdUslugi.Location = new System.Drawing.Point(108, 16);
            this.tbIdUslugi.MaxLength = 4;
            this.tbIdUslugi.Name = "tbIdUslugi";
            this.tbIdUslugi.Size = new System.Drawing.Size(100, 20);
            this.tbIdUslugi.TabIndex = 9;
            this.tbIdUslugi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdUslugi_KeyPress);
            this.tbIdUslugi.Leave += new System.EventHandler(this.tbIdUslugi_Leave);
            // 
            // lbIdUslugi
            // 
            this.lbIdUslugi.AutoSize = true;
            this.lbIdUslugi.Location = new System.Drawing.Point(10, 19);
            this.lbIdUslugi.Name = "lbIdUslugi";
            this.lbIdUslugi.Size = new System.Drawing.Size(55, 13);
            this.lbIdUslugi.TabIndex = 8;
            this.lbIdUslugi.Text = "ID Usługi:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Location = new System.Drawing.Point(117, 124);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 17;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(13, 124);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 16;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormUsluga
            // 
            this.AcceptButton = this.btnZapisz;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuluj;
            this.ClientSize = new System.Drawing.Size(214, 161);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.tbJednostkaMiary);
            this.Controls.Add(this.lbJednostkaMiary);
            this.Controls.Add(this.tbCenaJednostkowa);
            this.Controls.Add(this.lbCenaJednostkowa);
            this.Controls.Add(this.tbNazwa);
            this.Controls.Add(this.lbNazwa);
            this.Controls.Add(this.tbIdUslugi);
            this.Controls.Add(this.lbIdUslugi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(230, 200);
            this.MinimumSize = new System.Drawing.Size(230, 200);
            this.Name = "FormUsluga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usługa";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbJednostkaMiary;
        private System.Windows.Forms.Label lbJednostkaMiary;
        private System.Windows.Forms.TextBox tbCenaJednostkowa;
        private System.Windows.Forms.Label lbCenaJednostkowa;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.Label lbNazwa;
        private System.Windows.Forms.TextBox tbIdUslugi;
        private System.Windows.Forms.Label lbIdUslugi;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}