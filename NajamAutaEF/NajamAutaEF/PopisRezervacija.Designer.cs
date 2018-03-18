namespace NajamAutaEF
{
    partial class PopisRezervacija
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rezervacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervacijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voziloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prikolicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pocetakPosudbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istekPosudbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaPosudbeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prikoliceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervacijaIDDataGridViewTextBoxColumn,
            this.klijentDataGridViewTextBoxColumn,
            this.lokacijaDataGridViewTextBoxColumn,
            this.voziloDataGridViewTextBoxColumn,
            this.prikolicaDataGridViewTextBoxColumn,
            this.pocetakPosudbeDataGridViewTextBoxColumn,
            this.istekPosudbeDataGridViewTextBoxColumn,
            this.cijenaPosudbeDataGridViewTextBoxColumn,
            this.klijentiDataGridViewTextBoxColumn,
            this.lokacijeDataGridViewTextBoxColumn,
            this.prikoliceDataGridViewTextBoxColumn,
            this.vozilaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervacijeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(598, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // rezervacijeBindingSource
            // 
            this.rezervacijeBindingSource.DataSource = typeof(NajamAutaEF.Rezervacije);
            // 
            // rezervacijaIDDataGridViewTextBoxColumn
            // 
            this.rezervacijaIDDataGridViewTextBoxColumn.DataPropertyName = "RezervacijaID";
            this.rezervacijaIDDataGridViewTextBoxColumn.HeaderText = "#";
            this.rezervacijaIDDataGridViewTextBoxColumn.Name = "rezervacijaIDDataGridViewTextBoxColumn";
            this.rezervacijaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijaIDDataGridViewTextBoxColumn.Width = 30;
            // 
            // klijentDataGridViewTextBoxColumn
            // 
            this.klijentDataGridViewTextBoxColumn.DataPropertyName = "Klijent";
            this.klijentDataGridViewTextBoxColumn.HeaderText = "Klijent";
            this.klijentDataGridViewTextBoxColumn.Name = "klijentDataGridViewTextBoxColumn";
            this.klijentDataGridViewTextBoxColumn.ReadOnly = true;
            this.klijentDataGridViewTextBoxColumn.Width = 45;
            // 
            // lokacijaDataGridViewTextBoxColumn
            // 
            this.lokacijaDataGridViewTextBoxColumn.DataPropertyName = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.HeaderText = "Lokacija";
            this.lokacijaDataGridViewTextBoxColumn.Name = "lokacijaDataGridViewTextBoxColumn";
            this.lokacijaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacijaDataGridViewTextBoxColumn.Width = 60;
            // 
            // voziloDataGridViewTextBoxColumn
            // 
            this.voziloDataGridViewTextBoxColumn.DataPropertyName = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.voziloDataGridViewTextBoxColumn.Name = "voziloDataGridViewTextBoxColumn";
            this.voziloDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloDataGridViewTextBoxColumn.Width = 50;
            // 
            // prikolicaDataGridViewTextBoxColumn
            // 
            this.prikolicaDataGridViewTextBoxColumn.DataPropertyName = "Prikolica";
            this.prikolicaDataGridViewTextBoxColumn.HeaderText = "Prikolica";
            this.prikolicaDataGridViewTextBoxColumn.Name = "prikolicaDataGridViewTextBoxColumn";
            this.prikolicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.prikolicaDataGridViewTextBoxColumn.Width = 60;
            // 
            // pocetakPosudbeDataGridViewTextBoxColumn
            // 
            this.pocetakPosudbeDataGridViewTextBoxColumn.DataPropertyName = "PocetakPosudbe";
            this.pocetakPosudbeDataGridViewTextBoxColumn.HeaderText = "Datum početka";
            this.pocetakPosudbeDataGridViewTextBoxColumn.Name = "pocetakPosudbeDataGridViewTextBoxColumn";
            this.pocetakPosudbeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pocetakPosudbeDataGridViewTextBoxColumn.Width = 110;
            // 
            // istekPosudbeDataGridViewTextBoxColumn
            // 
            this.istekPosudbeDataGridViewTextBoxColumn.DataPropertyName = "IstekPosudbe";
            this.istekPosudbeDataGridViewTextBoxColumn.HeaderText = "Datum isteka";
            this.istekPosudbeDataGridViewTextBoxColumn.Name = "istekPosudbeDataGridViewTextBoxColumn";
            this.istekPosudbeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaPosudbeDataGridViewTextBoxColumn
            // 
            this.cijenaPosudbeDataGridViewTextBoxColumn.DataPropertyName = "CijenaPosudbe";
            this.cijenaPosudbeDataGridViewTextBoxColumn.HeaderText = "Iznos (HRK)";
            this.cijenaPosudbeDataGridViewTextBoxColumn.Name = "cijenaPosudbeDataGridViewTextBoxColumn";
            this.cijenaPosudbeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // klijentiDataGridViewTextBoxColumn
            // 
            this.klijentiDataGridViewTextBoxColumn.DataPropertyName = "Klijenti";
            this.klijentiDataGridViewTextBoxColumn.HeaderText = "Klijenti";
            this.klijentiDataGridViewTextBoxColumn.Name = "klijentiDataGridViewTextBoxColumn";
            this.klijentiDataGridViewTextBoxColumn.ReadOnly = true;
            this.klijentiDataGridViewTextBoxColumn.Visible = false;
            // 
            // lokacijeDataGridViewTextBoxColumn
            // 
            this.lokacijeDataGridViewTextBoxColumn.DataPropertyName = "Lokacije";
            this.lokacijeDataGridViewTextBoxColumn.HeaderText = "Lokacije";
            this.lokacijeDataGridViewTextBoxColumn.Name = "lokacijeDataGridViewTextBoxColumn";
            this.lokacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // prikoliceDataGridViewTextBoxColumn
            // 
            this.prikoliceDataGridViewTextBoxColumn.DataPropertyName = "Prikolice";
            this.prikoliceDataGridViewTextBoxColumn.HeaderText = "Prikolice";
            this.prikoliceDataGridViewTextBoxColumn.Name = "prikoliceDataGridViewTextBoxColumn";
            this.prikoliceDataGridViewTextBoxColumn.ReadOnly = true;
            this.prikoliceDataGridViewTextBoxColumn.Visible = false;
            // 
            // vozilaDataGridViewTextBoxColumn
            // 
            this.vozilaDataGridViewTextBoxColumn.DataPropertyName = "Vozila";
            this.vozilaDataGridViewTextBoxColumn.HeaderText = "Vozila";
            this.vozilaDataGridViewTextBoxColumn.Name = "vozilaDataGridViewTextBoxColumn";
            this.vozilaDataGridViewTextBoxColumn.ReadOnly = true;
            this.vozilaDataGridViewTextBoxColumn.Visible = false;
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.Location = new System.Drawing.Point(243, 183);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(135, 30);
            this.btnIzvjestaj.TabIndex = 1;
            this.btnIzvjestaj.Text = "Detaljan izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // PopisRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 226);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopisRezervacija";
            this.Text = "PopisRezervacija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacijeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prikolicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pocetakPosudbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istekPosudbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaPosudbeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prikoliceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rezervacijeBindingSource;
        private System.Windows.Forms.Button btnIzvjestaj;
    }
}