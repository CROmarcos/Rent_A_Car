namespace NajamAutaEF
{
    partial class NovoVozilo
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
            System.Windows.Forms.Label markaLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label godisteLabel;
            System.Windows.Forms.Label gorivoLabel;
            System.Windows.Forms.Label dnevniNajamLabel;
            System.Windows.Forms.Label brojSjedalaLabel;
            this.markaTextBox = new System.Windows.Forms.TextBox();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.godisteComboBox = new System.Windows.Forms.ComboBox();
            this.gorivoComboBox = new System.Windows.Forms.ComboBox();
            this.dnevniNajamTextBox = new System.Windows.Forms.TextBox();
            this.brojSjedalaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDa = new System.Windows.Forms.RadioButton();
            this.rbNe = new System.Windows.Forms.RadioButton();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            markaLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            godisteLabel = new System.Windows.Forms.Label();
            gorivoLabel = new System.Windows.Forms.Label();
            dnevniNajamLabel = new System.Windows.Forms.Label();
            brojSjedalaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // markaLabel
            // 
            markaLabel.AutoSize = true;
            markaLabel.Location = new System.Drawing.Point(131, 26);
            markaLabel.Name = "markaLabel";
            markaLabel.Size = new System.Drawing.Size(40, 13);
            markaLabel.TabIndex = 1;
            markaLabel.Text = "Marka:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(132, 52);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Model:";
            // 
            // godisteLabel
            // 
            godisteLabel.AutoSize = true;
            godisteLabel.Location = new System.Drawing.Point(70, 78);
            godisteLabel.Name = "godisteLabel";
            godisteLabel.Size = new System.Drawing.Size(101, 13);
            godisteLabel.TabIndex = 4;
            godisteLabel.Text = "Godina proizvodnje:";
            // 
            // gorivoLabel
            // 
            gorivoLabel.AutoSize = true;
            gorivoLabel.Location = new System.Drawing.Point(130, 105);
            gorivoLabel.Name = "gorivoLabel";
            gorivoLabel.Size = new System.Drawing.Size(41, 13);
            gorivoLabel.TabIndex = 6;
            gorivoLabel.Text = "Gorivo:";
            // 
            // dnevniNajamLabel
            // 
            dnevniNajamLabel.AutoSize = true;
            dnevniNajamLabel.Location = new System.Drawing.Point(27, 132);
            dnevniNajamLabel.Name = "dnevniNajamLabel";
            dnevniNajamLabel.Size = new System.Drawing.Size(144, 13);
            dnevniNajamLabel.TabIndex = 8;
            dnevniNajamLabel.Text = "Iznod dnevnog najma (HRK):";
            // 
            // brojSjedalaLabel
            // 
            brojSjedalaLabel.AutoSize = true;
            brojSjedalaLabel.Location = new System.Drawing.Point(107, 158);
            brojSjedalaLabel.Name = "brojSjedalaLabel";
            brojSjedalaLabel.Size = new System.Drawing.Size(64, 13);
            brojSjedalaLabel.TabIndex = 10;
            brojSjedalaLabel.Text = "Broj sjedala:";
            // 
            // markaTextBox
            // 
            this.markaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Marka", true));
            this.markaTextBox.Location = new System.Drawing.Point(177, 23);
            this.markaTextBox.Name = "markaTextBox";
            this.markaTextBox.Size = new System.Drawing.Size(100, 20);
            this.markaTextBox.TabIndex = 2;
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataSource = typeof(NajamAutaEF.Vozila);
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(177, 49);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 3;
            // 
            // godisteComboBox
            // 
            this.godisteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Godiste", true));
            this.godisteComboBox.FormattingEnabled = true;
            this.godisteComboBox.Location = new System.Drawing.Point(177, 75);
            this.godisteComboBox.Name = "godisteComboBox";
            this.godisteComboBox.Size = new System.Drawing.Size(100, 21);
            this.godisteComboBox.TabIndex = 5;
            // 
            // gorivoComboBox
            // 
            this.gorivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "Gorivo", true));
            this.gorivoComboBox.FormattingEnabled = true;
            this.gorivoComboBox.Items.AddRange(new object[] {
            "benzin",
            "benzin+plin",
            "dizel",
            "hybrid"});
            this.gorivoComboBox.Location = new System.Drawing.Point(177, 102);
            this.gorivoComboBox.Name = "gorivoComboBox";
            this.gorivoComboBox.Size = new System.Drawing.Size(100, 21);
            this.gorivoComboBox.TabIndex = 7;
            // 
            // dnevniNajamTextBox
            // 
            this.dnevniNajamTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "DnevniNajam", true));
            this.dnevniNajamTextBox.Location = new System.Drawing.Point(177, 129);
            this.dnevniNajamTextBox.Name = "dnevniNajamTextBox";
            this.dnevniNajamTextBox.Size = new System.Drawing.Size(100, 20);
            this.dnevniNajamTextBox.TabIndex = 9;
            // 
            // brojSjedalaTextBox
            // 
            this.brojSjedalaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vozilaBindingSource, "BrojSjedala", true));
            this.brojSjedalaTextBox.Location = new System.Drawing.Point(177, 155);
            this.brojSjedalaTextBox.Name = "brojSjedalaTextBox";
            this.brojSjedalaTextBox.Size = new System.Drawing.Size(100, 20);
            this.brojSjedalaTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Posjeduje li automobil kuku za vuču?";
            // 
            // rbDa
            // 
            this.rbDa.AutoSize = true;
            this.rbDa.Location = new System.Drawing.Point(111, 214);
            this.rbDa.Name = "rbDa";
            this.rbDa.Size = new System.Drawing.Size(40, 17);
            this.rbDa.TabIndex = 13;
            this.rbDa.TabStop = true;
            this.rbDa.Text = "DA";
            this.rbDa.UseVisualStyleBackColor = true;
            // 
            // rbNe
            // 
            this.rbNe.AutoSize = true;
            this.rbNe.Location = new System.Drawing.Point(174, 214);
            this.rbNe.Name = "rbNe";
            this.rbNe.Size = new System.Drawing.Size(40, 17);
            this.rbNe.TabIndex = 14;
            this.rbNe.TabStop = true;
            this.rbNe.Text = "NE";
            this.rbNe.UseVisualStyleBackColor = true;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(63, 247);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 33);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(177, 247);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 33);
            this.btnOdustani.TabIndex = 16;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // NovoVozilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 299);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.rbNe);
            this.Controls.Add(this.rbDa);
            this.Controls.Add(this.label1);
            this.Controls.Add(brojSjedalaLabel);
            this.Controls.Add(this.brojSjedalaTextBox);
            this.Controls.Add(dnevniNajamLabel);
            this.Controls.Add(this.dnevniNajamTextBox);
            this.Controls.Add(gorivoLabel);
            this.Controls.Add(this.gorivoComboBox);
            this.Controls.Add(godisteLabel);
            this.Controls.Add(this.godisteComboBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(markaLabel);
            this.Controls.Add(this.markaTextBox);
            this.Name = "NovoVozilo";
            this.Text = "NovoVozilo";
            this.Load += new System.EventHandler(this.NovoVozilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private System.Windows.Forms.TextBox markaTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.ComboBox godisteComboBox;
        private System.Windows.Forms.ComboBox gorivoComboBox;
        private System.Windows.Forms.TextBox dnevniNajamTextBox;
        private System.Windows.Forms.TextBox brojSjedalaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDa;
        private System.Windows.Forms.RadioButton rbNe;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}