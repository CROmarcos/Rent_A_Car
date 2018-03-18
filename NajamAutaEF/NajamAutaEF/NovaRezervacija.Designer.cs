namespace NajamAutaEF
{
    partial class NovaRezervacija
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
            System.Windows.Forms.Label klijentLabel;
            System.Windows.Forms.Label voziloLabel;
            System.Windows.Forms.Label lokacijaLabel;
            System.Windows.Forms.Label prikolicaLabel;
            System.Windows.Forms.Label istekPosudbeLabel;
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klijentComboBox = new System.Windows.Forms.ComboBox();
            this.klijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voziloComboBox = new System.Windows.Forms.ComboBox();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lokacijaComboBox = new System.Windows.Forms.ComboBox();
            this.lokacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prikolicaComboBox = new System.Windows.Forms.ComboBox();
            this.prikoliceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istekPosudbeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            klijentLabel = new System.Windows.Forms.Label();
            voziloLabel = new System.Windows.Forms.Label();
            lokacijaLabel = new System.Windows.Forms.Label();
            prikolicaLabel = new System.Windows.Forms.Label();
            istekPosudbeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikoliceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // klijentLabel
            // 
            klijentLabel.AutoSize = true;
            klijentLabel.Location = new System.Drawing.Point(65, 15);
            klijentLabel.Name = "klijentLabel";
            klijentLabel.Size = new System.Drawing.Size(38, 13);
            klijentLabel.TabIndex = 0;
            klijentLabel.Text = "Klijent:";
            // 
            // voziloLabel
            // 
            voziloLabel.AutoSize = true;
            voziloLabel.Location = new System.Drawing.Point(65, 69);
            voziloLabel.Name = "voziloLabel";
            voziloLabel.Size = new System.Drawing.Size(38, 13);
            voziloLabel.TabIndex = 2;
            voziloLabel.Text = "Vozilo:";
            // 
            // lokacijaLabel
            // 
            lokacijaLabel.AutoSize = true;
            lokacijaLabel.Location = new System.Drawing.Point(53, 42);
            lokacijaLabel.Name = "lokacijaLabel";
            lokacijaLabel.Size = new System.Drawing.Size(50, 13);
            lokacijaLabel.TabIndex = 4;
            lokacijaLabel.Text = "Lokacija:";
            // 
            // prikolicaLabel
            // 
            prikolicaLabel.AutoSize = true;
            prikolicaLabel.Location = new System.Drawing.Point(53, 96);
            prikolicaLabel.Name = "prikolicaLabel";
            prikolicaLabel.Size = new System.Drawing.Size(50, 13);
            prikolicaLabel.TabIndex = 6;
            prikolicaLabel.Text = "Prikolica:";
            // 
            // istekPosudbeLabel
            // 
            istekPosudbeLabel.AutoSize = true;
            istekPosudbeLabel.Location = new System.Drawing.Point(25, 124);
            istekPosudbeLabel.Name = "istekPosudbeLabel";
            istekPosudbeLabel.Size = new System.Drawing.Size(78, 13);
            istekPosudbeLabel.TabIndex = 8;
            istekPosudbeLabel.Text = "Istek Posudbe:";
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataSource = typeof(NajamAutaEF.Rezervacije);
            // 
            // klijentComboBox
            // 
            this.klijentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "Klijent", true));
            this.klijentComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rezervacijeBindingSource, "Klijent", true));
            this.klijentComboBox.DataSource = this.klijentiBindingSource;
            this.klijentComboBox.FormattingEnabled = true;
            this.klijentComboBox.Location = new System.Drawing.Point(109, 12);
            this.klijentComboBox.Name = "klijentComboBox";
            this.klijentComboBox.Size = new System.Drawing.Size(121, 21);
            this.klijentComboBox.TabIndex = 1;
            this.klijentComboBox.ValueMember = "KlijentID";
            // 
            // klijentiBindingSource
            // 
            this.klijentiBindingSource.DataSource = typeof(NajamAutaEF.Klijenti);
            // 
            // voziloComboBox
            // 
            this.voziloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "Vozilo", true));
            this.voziloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rezervacijeBindingSource, "Vozilo", true));
            this.voziloComboBox.DataSource = this.vozilaBindingSource;
            this.voziloComboBox.FormattingEnabled = true;
            this.voziloComboBox.Location = new System.Drawing.Point(109, 66);
            this.voziloComboBox.Name = "voziloComboBox";
            this.voziloComboBox.Size = new System.Drawing.Size(121, 21);
            this.voziloComboBox.TabIndex = 3;
            this.voziloComboBox.ValueMember = "VoziloID";
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataSource = typeof(NajamAutaEF.Vozila);
            // 
            // lokacijaComboBox
            // 
            this.lokacijaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "Lokacija", true));
            this.lokacijaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rezervacijeBindingSource, "Lokacija", true));
            this.lokacijaComboBox.DataSource = this.lokacijeBindingSource;
            this.lokacijaComboBox.DisplayMember = "Grad";
            this.lokacijaComboBox.FormattingEnabled = true;
            this.lokacijaComboBox.Location = new System.Drawing.Point(109, 39);
            this.lokacijaComboBox.Name = "lokacijaComboBox";
            this.lokacijaComboBox.Size = new System.Drawing.Size(121, 21);
            this.lokacijaComboBox.TabIndex = 5;
            this.lokacijaComboBox.ValueMember = "LokacijaID";
            // 
            // lokacijeBindingSource
            // 
            this.lokacijeBindingSource.DataSource = typeof(NajamAutaEF.Lokacije);
            // 
            // prikolicaComboBox
            // 
            this.prikolicaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rezervacijeBindingSource, "Prikolica", true));
            this.prikolicaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rezervacijeBindingSource, "Prikolica", true));
            this.prikolicaComboBox.DataSource = this.prikoliceBindingSource;
            this.prikolicaComboBox.DisplayMember = "TipPrikolice";
            this.prikolicaComboBox.FormattingEnabled = true;
            this.prikolicaComboBox.Location = new System.Drawing.Point(109, 93);
            this.prikolicaComboBox.Name = "prikolicaComboBox";
            this.prikolicaComboBox.Size = new System.Drawing.Size(121, 21);
            this.prikolicaComboBox.TabIndex = 7;
            this.prikolicaComboBox.ValueMember = "PrikolicaID";
            // 
            // prikoliceBindingSource
            // 
            this.prikoliceBindingSource.DataSource = typeof(NajamAutaEF.Prikolice);
            // 
            // istekPosudbeDateTimePicker
            // 
            this.istekPosudbeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rezervacijeBindingSource, "IstekPosudbe", true));
            this.istekPosudbeDateTimePicker.Location = new System.Drawing.Point(109, 120);
            this.istekPosudbeDateTimePicker.Name = "istekPosudbeDateTimePicker";
            this.istekPosudbeDateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.istekPosudbeDateTimePicker.TabIndex = 9;
            // 
            // NovaRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 265);
            this.Controls.Add(istekPosudbeLabel);
            this.Controls.Add(this.istekPosudbeDateTimePicker);
            this.Controls.Add(prikolicaLabel);
            this.Controls.Add(this.prikolicaComboBox);
            this.Controls.Add(lokacijaLabel);
            this.Controls.Add(this.lokacijaComboBox);
            this.Controls.Add(voziloLabel);
            this.Controls.Add(this.voziloComboBox);
            this.Controls.Add(klijentLabel);
            this.Controls.Add(this.klijentComboBox);
            this.Name = "NovaRezervacija";
            this.Text = "NovaRezervacija";
            this.Load += new System.EventHandler(this.NovaRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikoliceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private System.Windows.Forms.ComboBox klijentComboBox;
        private System.Windows.Forms.BindingSource klijentiBindingSource;
        private System.Windows.Forms.ComboBox voziloComboBox;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private System.Windows.Forms.ComboBox lokacijaComboBox;
        private System.Windows.Forms.BindingSource lokacijeBindingSource;
        private System.Windows.Forms.ComboBox prikolicaComboBox;
        private System.Windows.Forms.BindingSource prikoliceBindingSource;
        private System.Windows.Forms.DateTimePicker istekPosudbeDateTimePicker;
    }
}