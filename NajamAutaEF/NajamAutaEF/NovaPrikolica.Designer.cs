namespace NajamAutaEF
{
    partial class NovaPrikolica
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
            System.Windows.Forms.Label tipPrikoliceLabel;
            System.Windows.Forms.Label brojOsovinaLabel;
            System.Windows.Forms.Label dnevniNajamLabel;
            this.tipPrikoliceTextBox = new System.Windows.Forms.TextBox();
            this.prikoliceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brojOsovinaComboBox = new System.Windows.Forms.ComboBox();
            this.dnevniNajamTextBox = new System.Windows.Forms.TextBox();
            this.beCheckBox = new System.Windows.Forms.CheckBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            tipPrikoliceLabel = new System.Windows.Forms.Label();
            brojOsovinaLabel = new System.Windows.Forms.Label();
            dnevniNajamLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prikoliceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tipPrikoliceLabel
            // 
            tipPrikoliceLabel.AutoSize = true;
            tipPrikoliceLabel.Location = new System.Drawing.Point(90, 15);
            tipPrikoliceLabel.Name = "tipPrikoliceLabel";
            tipPrikoliceLabel.Size = new System.Drawing.Size(67, 13);
            tipPrikoliceLabel.TabIndex = 1;
            tipPrikoliceLabel.Text = "Tip prikolice:";
            // 
            // tipPrikoliceTextBox
            // 
            this.tipPrikoliceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prikoliceBindingSource, "TipPrikolice", true));
            this.tipPrikoliceTextBox.Location = new System.Drawing.Point(163, 12);
            this.tipPrikoliceTextBox.Name = "tipPrikoliceTextBox";
            this.tipPrikoliceTextBox.Size = new System.Drawing.Size(100, 20);
            this.tipPrikoliceTextBox.TabIndex = 2;
            // 
            // prikoliceBindingSource
            // 
            this.prikoliceBindingSource.DataSource = typeof(NajamAutaEF.Prikolice);
            // 
            // brojOsovinaLabel
            // 
            brojOsovinaLabel.AutoSize = true;
            brojOsovinaLabel.Location = new System.Drawing.Point(90, 41);
            brojOsovinaLabel.Name = "brojOsovinaLabel";
            brojOsovinaLabel.Size = new System.Drawing.Size(68, 13);
            brojOsovinaLabel.TabIndex = 2;
            brojOsovinaLabel.Text = "Broj osovina:";
            // 
            // brojOsovinaComboBox
            // 
            this.brojOsovinaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prikoliceBindingSource, "BrojOsovina", true));
            this.brojOsovinaComboBox.FormattingEnabled = true;
            this.brojOsovinaComboBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.brojOsovinaComboBox.Location = new System.Drawing.Point(163, 38);
            this.brojOsovinaComboBox.Name = "brojOsovinaComboBox";
            this.brojOsovinaComboBox.Size = new System.Drawing.Size(100, 21);
            this.brojOsovinaComboBox.TabIndex = 3;
            // 
            // dnevniNajamLabel
            // 
            dnevniNajamLabel.AutoSize = true;
            dnevniNajamLabel.Location = new System.Drawing.Point(14, 68);
            dnevniNajamLabel.Name = "dnevniNajamLabel";
            dnevniNajamLabel.Size = new System.Drawing.Size(143, 13);
            dnevniNajamLabel.TabIndex = 4;
            dnevniNajamLabel.Text = "Iznos dnevnog najma (HRK):";
            // 
            // dnevniNajamTextBox
            // 
            this.dnevniNajamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prikoliceBindingSource, "DnevniNajam", true));
            this.dnevniNajamTextBox.Location = new System.Drawing.Point(163, 65);
            this.dnevniNajamTextBox.Name = "dnevniNajamTextBox";
            this.dnevniNajamTextBox.Size = new System.Drawing.Size(100, 20);
            this.dnevniNajamTextBox.TabIndex = 5;
            // 
            // beCheckBox
            // 
            this.beCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prikoliceBindingSource, "PotrebaBE", true));
            this.beCheckBox.Location = new System.Drawing.Point(73, 91);
            this.beCheckBox.Name = "beCheckBox";
            this.beCheckBox.Size = new System.Drawing.Size(167, 24);
            this.beCheckBox.TabIndex = 7;
            this.beCheckBox.Text = "Potreba za B+E kategorijom";
            this.beCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(40, 124);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(79, 30);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(149, 124);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(79, 30);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // NovaPrikolica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 168);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.beCheckBox);
            this.Controls.Add(dnevniNajamLabel);
            this.Controls.Add(this.dnevniNajamTextBox);
            this.Controls.Add(brojOsovinaLabel);
            this.Controls.Add(this.brojOsovinaComboBox);
            this.Controls.Add(tipPrikoliceLabel);
            this.Controls.Add(this.tipPrikoliceTextBox);
            this.Name = "NovaPrikolica";
            this.Text = "NovaPrikolica";
            ((System.ComponentModel.ISupportInitialize)(this.prikoliceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource prikoliceBindingSource;
        private System.Windows.Forms.TextBox tipPrikoliceTextBox;
        private System.Windows.Forms.ComboBox brojOsovinaComboBox;
        private System.Windows.Forms.TextBox dnevniNajamTextBox;
        private System.Windows.Forms.CheckBox beCheckBox;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}