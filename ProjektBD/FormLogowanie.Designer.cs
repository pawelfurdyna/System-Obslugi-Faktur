namespace ProjektBD
{
    partial class FormLogowanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogowanie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.btZaloguj = new System.Windows.Forms.Button();
            this.btAnuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasło:";
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(57, 54);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(165, 20);
            this.tbHaslo.TabIndex = 2;
            this.tbHaslo.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(57, 21);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(165, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // btZaloguj
            // 
            this.btZaloguj.BackColor = System.Drawing.SystemColors.Info;
            this.btZaloguj.Location = new System.Drawing.Point(66, 86);
            this.btZaloguj.Name = "btZaloguj";
            this.btZaloguj.Size = new System.Drawing.Size(75, 23);
            this.btZaloguj.TabIndex = 3;
            this.btZaloguj.Text = "Zaloguj";
            this.btZaloguj.UseVisualStyleBackColor = false;
            this.btZaloguj.Click += new System.EventHandler(this.btZaloguj_Click);
            // 
            // btAnuluj
            // 
            this.btAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAnuluj.Location = new System.Drawing.Point(147, 86);
            this.btAnuluj.Name = "btAnuluj";
            this.btAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btAnuluj.TabIndex = 4;
            this.btAnuluj.Text = "Anuluj";
            this.btAnuluj.UseVisualStyleBackColor = true;
            this.btAnuluj.Click += new System.EventHandler(this.btAnuluj_Click);
            // 
            // FormLogowanie
            // 
            this.AcceptButton = this.btZaloguj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAnuluj;
            this.ClientSize = new System.Drawing.Size(234, 121);
            this.Controls.Add(this.btAnuluj);
            this.Controls.Add(this.btZaloguj);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 160);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 160);
            this.Name = "FormLogowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.FormLogowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button btZaloguj;
        private System.Windows.Forms.Button btAnuluj;
    }
}