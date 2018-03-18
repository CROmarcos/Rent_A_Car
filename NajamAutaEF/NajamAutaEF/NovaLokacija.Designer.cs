namespace NajamAutaEF
{
    partial class NovaLokacija
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
            System.Windows.Forms.Label zupanijaLabel;
            System.Windows.Forms.Label gradLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label cijenaDovozaLabel;
            this.zupanijaTextBox = new System.Windows.Forms.TextBox();
            this.lokacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.cijenaDovozaTextBox = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            zupanijaLabel = new System.Windows.Forms.Label();
            gradLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            cijenaDovozaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zupanijaLabel
            // 
            zupanijaLabel.AutoSize = true;
            zupanijaLabel.Location = new System.Drawing.Point(75, 29);
            zupanijaLabel.Name = "zupanijaLabel";
            zupanijaLabel.Size = new System.Drawing.Size(51, 13);
            zupanijaLabel.TabIndex = 1;
            zupanijaLabel.Text = "Županija:";
            // 
            // zupanijaTextBox
            // 
            this.zupanijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijeBindingSource, "Zupanija", true));
            this.zupanijaTextBox.Location = new System.Drawing.Point(132, 26);
            this.zupanijaTextBox.Name = "zupanijaTextBox";
            this.zupanijaTextBox.Size = new System.Drawing.Size(100, 20);
            this.zupanijaTextBox.TabIndex = 2;
            // 
            // lokacijeBindingSource
            // 
            this.lokacijeBindingSource.DataSource = typeof(NajamAutaEF.Lokacije);
            // 
            // gradLabel
            // 
            gradLabel.AutoSize = true;
            gradLabel.Location = new System.Drawing.Point(93, 55);
            gradLabel.Name = "gradLabel";
            gradLabel.Size = new System.Drawing.Size(33, 13);
            gradLabel.TabIndex = 2;
            gradLabel.Text = "Grad:";
            // 
            // gradTextBox
            // 
            this.gradTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijeBindingSource, "Grad", true));
            this.gradTextBox.Location = new System.Drawing.Point(132, 52);
            this.gradTextBox.Name = "gradTextBox";
            this.gradTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradTextBox.TabIndex = 3;
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(83, 81);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 4;
            adresaLabel.Text = "Adresa:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijeBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(132, 78);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 5;
            // 
            // cijenaDovozaLabel
            // 
            cijenaDovozaLabel.AutoSize = true;
            cijenaDovozaLabel.Location = new System.Drawing.Point(17, 107);
            cijenaDovozaLabel.Name = "cijenaDovozaLabel";
            cijenaDovozaLabel.Size = new System.Drawing.Size(109, 13);
            cijenaDovozaLabel.TabIndex = 6;
            cijenaDovozaLabel.Text = "Cijena dovoza (HRK):";
            // 
            // cijenaDovozaTextBox
            // 
            this.cijenaDovozaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lokacijeBindingSource, "CijenaDovoza", true));
            this.cijenaDovozaTextBox.Location = new System.Drawing.Point(132, 104);
            this.cijenaDovozaTextBox.Name = "cijenaDovozaTextBox";
            this.cijenaDovozaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cijenaDovozaTextBox.TabIndex = 7;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(35, 146);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(75, 36);
            this.btnSpremi.TabIndex = 8;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(142, 146);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 36);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // NovaLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 201);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(cijenaDovozaLabel);
            this.Controls.Add(this.cijenaDovozaTextBox);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(gradLabel);
            this.Controls.Add(this.gradTextBox);
            this.Controls.Add(zupanijaLabel);
            this.Controls.Add(this.zupanijaTextBox);
            this.Name = "NovaLokacija";
            this.Text = "NovaLokacija";
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lokacijeBindingSource;
        private System.Windows.Forms.TextBox zupanijaTextBox;
        private System.Windows.Forms.TextBox gradTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.TextBox cijenaDovozaTextBox;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.Button btnOdustani;
    }
}