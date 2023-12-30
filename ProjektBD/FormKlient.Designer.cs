namespace ProjektBD
{
    partial class FormKlient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKlient));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbNumerTelefonu = new System.Windows.Forms.TextBox();
            this.lbNumerTelefonu = new System.Windows.Forms.Label();
            this.tbNip = new System.Windows.Forms.TextBox();
            this.lbNip = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.lbAdres = new System.Windows.Forms.Label();
            this.tbNazwa = new System.Windows.Forms.TextBox();
            this.lbNazwa = new System.Windows.Forms.Label();
            this.tbIdKlienta = new System.Windows.Forms.TextBox();
            this.lbIdKlienta = new System.Windows.Forms.Label();
            this.tbTerminPlatnosci = new System.Windows.Forms.TextBox();
            this.lbTerminPlatnosci = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(104, 142);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 23;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(11, 149);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(38, 13);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "E-mail:";
            // 
            // tbNumerTelefonu
            // 
            this.tbNumerTelefonu.Location = new System.Drawing.Point(104, 116);
            this.tbNumerTelefonu.Name = "tbNumerTelefonu";
            this.tbNumerTelefonu.Size = new System.Drawing.Size(100, 20);
            this.tbNumerTelefonu.TabIndex = 21;
            // 
            // lbNumerTelefonu
            // 
            this.lbNumerTelefonu.AutoSize = true;
            this.lbNumerTelefonu.Location = new System.Drawing.Point(11, 123);
            this.lbNumerTelefonu.Name = "lbNumerTelefonu";
            this.lbNumerTelefonu.Size = new System.Drawing.Size(82, 13);
            this.lbNumerTelefonu.TabIndex = 20;
            this.lbNumerTelefonu.Text = "Numer telefonu:";
            // 
            // tbNip
            // 
            this.tbNip.Location = new System.Drawing.Point(104, 90);
            this.tbNip.Name = "tbNip";
            this.tbNip.Size = new System.Drawing.Size(100, 20);
            this.tbNip.TabIndex = 19;
            // 
            // lbNip
            // 
            this.lbNip.AutoSize = true;
            this.lbNip.Location = new System.Drawing.Point(11, 97);
            this.lbNip.Name = "lbNip";
            this.lbNip.Size = new System.Drawing.Size(28, 13);
            this.lbNip.TabIndex = 18;
            this.lbNip.Text = "NIP:";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(104, 64);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(100, 20);
            this.tbAdres.TabIndex = 17;
            // 
            // lbAdres
            // 
            this.lbAdres.AutoSize = true;
            this.lbAdres.Location = new System.Drawing.Point(11, 71);
            this.lbAdres.Name = "lbAdres";
            this.lbAdres.Size = new System.Drawing.Size(37, 13);
            this.lbAdres.TabIndex = 16;
            this.lbAdres.Text = "Adres:";
            // 
            // tbNazwa
            // 
            this.tbNazwa.Location = new System.Drawing.Point(104, 38);
            this.tbNazwa.Name = "tbNazwa";
            this.tbNazwa.Size = new System.Drawing.Size(100, 20);
            this.tbNazwa.TabIndex = 15;
            // 
            // lbNazwa
            // 
            this.lbNazwa.AutoSize = true;
            this.lbNazwa.Location = new System.Drawing.Point(11, 45);
            this.lbNazwa.Name = "lbNazwa";
            this.lbNazwa.Size = new System.Drawing.Size(43, 13);
            this.lbNazwa.TabIndex = 14;
            this.lbNazwa.Text = "Nazwa:";
            // 
            // tbIdKlienta
            // 
            this.tbIdKlienta.Location = new System.Drawing.Point(104, 12);
            this.tbIdKlienta.Name = "tbIdKlienta";
            this.tbIdKlienta.Size = new System.Drawing.Size(100, 20);
            this.tbIdKlienta.TabIndex = 13;
            this.tbIdKlienta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdKlienta_KeyPress);
            // 
            // lbIdKlienta
            // 
            this.lbIdKlienta.AutoSize = true;
            this.lbIdKlienta.Location = new System.Drawing.Point(11, 19);
            this.lbIdKlienta.Name = "lbIdKlienta";
            this.lbIdKlienta.Size = new System.Drawing.Size(56, 13);
            this.lbIdKlienta.TabIndex = 12;
            this.lbIdKlienta.Text = "ID Klienta:";
            // 
            // tbTerminPlatnosci
            // 
            this.tbTerminPlatnosci.Location = new System.Drawing.Point(104, 168);
            this.tbTerminPlatnosci.Name = "tbTerminPlatnosci";
            this.tbTerminPlatnosci.Size = new System.Drawing.Size(100, 20);
            this.tbTerminPlatnosci.TabIndex = 25;
            this.tbTerminPlatnosci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTerminPlatnosci_KeyPress);
            // 
            // lbTerminPlatnosci
            // 
            this.lbTerminPlatnosci.AutoSize = true;
            this.lbTerminPlatnosci.Location = new System.Drawing.Point(11, 175);
            this.lbTerminPlatnosci.Name = "lbTerminPlatnosci";
            this.lbTerminPlatnosci.Size = new System.Drawing.Size(89, 13);
            this.lbTerminPlatnosci.TabIndex = 24;
            this.lbTerminPlatnosci.Text = "Termin płatności:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(118, 203);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 27;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(14, 203);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 26;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // FormKlient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 231);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.tbTerminPlatnosci);
            this.Controls.Add(this.lbTerminPlatnosci);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbNumerTelefonu);
            this.Controls.Add(this.lbNumerTelefonu);
            this.Controls.Add(this.tbNip);
            this.Controls.Add(this.lbNip);
            this.Controls.Add(this.tbAdres);
            this.Controls.Add(this.lbAdres);
            this.Controls.Add(this.tbNazwa);
            this.Controls.Add(this.lbNazwa);
            this.Controls.Add(this.tbIdKlienta);
            this.Controls.Add(this.lbIdKlienta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(230, 270);
            this.MinimumSize = new System.Drawing.Size(230, 270);
            this.Name = "FormKlient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbNumerTelefonu;
        private System.Windows.Forms.Label lbNumerTelefonu;
        private System.Windows.Forms.TextBox tbNip;
        private System.Windows.Forms.Label lbNip;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.Label lbAdres;
        private System.Windows.Forms.TextBox tbNazwa;
        private System.Windows.Forms.Label lbNazwa;
        private System.Windows.Forms.TextBox tbIdKlienta;
        private System.Windows.Forms.Label lbIdKlienta;
        private System.Windows.Forms.TextBox tbTerminPlatnosci;
        private System.Windows.Forms.Label lbTerminPlatnosci;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
    }
}