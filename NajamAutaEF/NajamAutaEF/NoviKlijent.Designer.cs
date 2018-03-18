namespace NajamAutaEF
{
    partial class NoviKlijent
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
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label godinaRodjenjaLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label mobitelLabel;
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.godinaRodjenjaComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.mobitelTextBox = new System.Windows.Forms.TextBox();
            this.kategorijaBECheckBox = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.klijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            godinaRodjenjaLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            mobitelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(84, 31);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 1;
            imeLabel.Text = "Ime:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentiBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(117, 28);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 2;
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(64, 57);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 2;
            prezimeLabel.Text = "Prezime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentiBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(117, 54);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 3;
            // 
            // godinaRodjenjaLabel
            // 
            godinaRodjenjaLabel.AutoSize = true;
            godinaRodjenjaLabel.Location = new System.Drawing.Point(28, 83);
            godinaRodjenjaLabel.Name = "godinaRodjenjaLabel";
            godinaRodjenjaLabel.Size = new System.Drawing.Size(83, 13);
            godinaRodjenjaLabel.TabIndex = 4;
            godinaRodjenjaLabel.Text = "Godina rođenja:";
            // 
            // godinaRodjenjaComboBox
            // 
            this.godinaRodjenjaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentiBindingSource, "GodinaRodjenja", true));
            this.godinaRodjenjaComboBox.FormattingEnabled = true;
            this.godinaRodjenjaComboBox.Location = new System.Drawing.Point(117, 80);
            this.godinaRodjenjaComboBox.Name = "godinaRodjenjaComboBox";
            this.godinaRodjenjaComboBox.Size = new System.Drawing.Size(100, 21);
            this.godinaRodjenjaComboBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(38, 110);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(73, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "E-mail adresa:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentiBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(117, 107);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // mobitelLabel
            // 
            mobitelLabel.AutoSize = true;
            mobitelLabel.Location = new System.Drawing.Point(41, 136);
            mobitelLabel.Name = "mobitelLabel";
            mobitelLabel.Size = new System.Drawing.Size(70, 13);
            mobitelLabel.TabIndex = 8;
            mobitelLabel.Text = "Broj mobitela:";
            // 
            // mobitelTextBox
            // 
            this.mobitelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klijentiBindingSource, "Mobitel", true));
            this.mobitelTextBox.Location = new System.Drawing.Point(117, 133);
            this.mobitelTextBox.Name = "mobitelTextBox";
            this.mobitelTextBox.Size = new System.Drawing.Size(100, 20);
            this.mobitelTextBox.TabIndex = 9;
            // 
            // kategorijaBECheckBox
            // 
            this.kategorijaBECheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.klijentiBindingSource, "KategorijaBE", true));
            this.kategorijaBECheckBox.Location = new System.Drawing.Point(31, 168);
            this.kategorijaBECheckBox.Name = "kategorijaBECheckBox";
            this.kategorijaBECheckBox.Size = new System.Drawing.Size(202, 19);
            this.kategorijaBECheckBox.TabIndex = 11;
            this.kategorijaBECheckBox.Text = "Klijent ima položenu B+E kategoriju.";
            this.kategorijaBECheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(37, 209);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(73, 29);
            this.btnSpremi.TabIndex = 12;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(144, 209);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(73, 29);
            this.btnOdustani.TabIndex = 13;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // klijentiBindingSource
            // 
            this.klijentiBindingSource.DataSource = typeof(NajamAutaEF.Klijenti);
            // 
            // NoviKlijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 265);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.kategorijaBECheckBox);
            this.Controls.Add(mobitelLabel);
            this.Controls.Add(this.mobitelTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(godinaRodjenjaLabel);
            this.Controls.Add(this.godinaRodjenjaComboBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Name = "NoviKlijent";
            this.Text = "NoviKlijent";
            this.Load += new System.EventHandler(this.NoviKlijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klijentiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource klijentiBindingSource;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.ComboBox godinaRodjenjaComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox mobitelTextBox;
        private System.Windows.Forms.CheckBox kategorijaBECheckBox;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}