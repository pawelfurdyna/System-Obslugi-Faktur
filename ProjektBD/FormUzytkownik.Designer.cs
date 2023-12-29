namespace ProjektBD
{
    partial class FormUzytkownik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUzytkownik));
            this.lbIdUzytkownika = new System.Windows.Forms.Label();
            this.tbIdUzytkownika = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.lbImie = new System.Windows.Forms.Label();
            this.tbNazwisko = new System.Windows.Forms.TextBox();
            this.lbNazwisko = new System.Windows.Forms.Label();
            this.tbRola = new System.Windows.Forms.TextBox();
            this.lbRola = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.lbHaslo = new System.Windows.Forms.Label();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIdUzytkownika
            // 
            this.lbIdUzytkownika.AutoSize = true;
            this.lbIdUzytkownika.Location = new System.Drawing.Point(12, 20);
            this.lbIdUzytkownika.Name = "lbIdUzytkownika";
            this.lbIdUzytkownika.Size = new System.Drawing.Size(85, 13);
            this.lbIdUzytkownika.TabIndex = 0;
            this.lbIdUzytkownika.Text = "ID Użytkownika:";
            // 
            // tbIdUzytkownika
            // 
            this.tbIdUzytkownika.Location = new System.Drawing.Point(100, 13);
            this.tbIdUzytkownika.Name = "tbIdUzytkownika";
            this.tbIdUzytkownika.Size = new System.Drawing.Size(100, 20);
            this.tbIdUzytkownika.TabIndex = 1;
            // 
            // tbImie
            // 
            this.tbImie.Location = new System.Drawing.Point(100, 39);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(100, 20);
            this.tbImie.TabIndex = 3;
            // 
            // lbImie
            // 
            this.lbImie.AutoSize = true;
            this.lbImie.Location = new System.Drawing.Point(12, 46);
            this.lbImie.Name = "lbImie";
            this.lbImie.Size = new System.Drawing.Size(29, 13);
            this.lbImie.TabIndex = 2;
            this.lbImie.Text = "Imię:";
            // 
            // tbNazwisko
            // 
            this.tbNazwisko.Location = new System.Drawing.Point(100, 65);
            this.tbNazwisko.Name = "tbNazwisko";
            this.tbNazwisko.Size = new System.Drawing.Size(100, 20);
            this.tbNazwisko.TabIndex = 5;
            // 
            // lbNazwisko
            // 
            this.lbNazwisko.AutoSize = true;
            this.lbNazwisko.Location = new System.Drawing.Point(12, 72);
            this.lbNazwisko.Name = "lbNazwisko";
            this.lbNazwisko.Size = new System.Drawing.Size(56, 13);
            this.lbNazwisko.TabIndex = 4;
            this.lbNazwisko.Text = "Nazwisko:";
            // 
            // tbRola
            // 
            this.tbRola.Location = new System.Drawing.Point(100, 91);
            this.tbRola.Name = "tbRola";
            this.tbRola.Size = new System.Drawing.Size(100, 20);
            this.tbRola.TabIndex = 7;
            // 
            // lbRola
            // 
            this.lbRola.AutoSize = true;
            this.lbRola.Location = new System.Drawing.Point(12, 98);
            this.lbRola.Name = "lbRola";
            this.lbRola.Size = new System.Drawing.Size(32, 13);
            this.lbRola.TabIndex = 6;
            this.lbRola.Text = "Rola:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(100, 117);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(100, 20);
            this.tbLogin.TabIndex = 9;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(12, 124);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(36, 13);
            this.lbLogin.TabIndex = 8;
            this.lbLogin.Text = "Login:";
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(100, 143);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(100, 20);
            this.tbHaslo.TabIndex = 11;
            // 
            // lbHaslo
            // 
            this.lbHaslo.AutoSize = true;
            this.lbHaslo.Location = new System.Drawing.Point(12, 150);
            this.lbHaslo.Name = "lbHaslo";
            this.lbHaslo.Size = new System.Drawing.Size(39, 13);
            this.lbHaslo.TabIndex = 10;
            this.lbHaslo.Text = "Hasło:";
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(119, 175);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 13;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(15, 175);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 12;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // FormUzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 211);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.lbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.tbRola);
            this.Controls.Add(this.lbRola);
            this.Controls.Add(this.tbNazwisko);
            this.Controls.Add(this.lbNazwisko);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.lbImie);
            this.Controls.Add(this.tbIdUzytkownika);
            this.Controls.Add(this.lbIdUzytkownika);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(230, 250);
            this.MinimumSize = new System.Drawing.Size(230, 250);
            this.Name = "FormUzytkownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Użytkownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdUzytkownika;
        private System.Windows.Forms.TextBox tbIdUzytkownika;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Label lbImie;
        private System.Windows.Forms.TextBox tbNazwisko;
        private System.Windows.Forms.Label lbNazwisko;
        private System.Windows.Forms.TextBox tbRola;
        private System.Windows.Forms.Label lbRola;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.Label lbHaslo;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button btnZapisz;
    }
}