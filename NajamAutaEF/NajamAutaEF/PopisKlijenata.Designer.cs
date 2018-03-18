namespace NajamAutaEF
{
    partial class PopisKlijenata
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
            this.dgvKlijenti = new System.Windows.Forms.DataGridView();
            this.klijentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godinaRodjenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategorijaBEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNoviKlijent = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKlijenti
            // 
            this.dgvKlijenti.AllowUserToAddRows = false;
            this.dgvKlijenti.AllowUserToDeleteRows = false;
            this.dgvKlijenti.AutoGenerateColumns = false;
            this.dgvKlijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klijentIDDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.godinaRodjenjaDataGridViewTextBoxColumn,
            this.kategorijaBEDataGridViewCheckBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobitelDataGridViewTextBoxColumn,
            this.rezervacijeDataGridViewTextBoxColumn});
            this.dgvKlijenti.DataSource = this.klijentiBindingSource;
            this.dgvKlijenti.Location = new System.Drawing.Point(13, 13);
            this.dgvKlijenti.Name = "dgvKlijenti";
            this.dgvKlijenti.ReadOnly = true;
            this.dgvKlijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKlijenti.Size = new System.Drawing.Size(644, 213);
            this.dgvKlijenti.TabIndex = 0;
            // 
            // klijentIDDataGridViewTextBoxColumn
            // 
            this.klijentIDDataGridViewTextBoxColumn.DataPropertyName = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.HeaderText = "KlijentID";
            this.klijentIDDataGridViewTextBoxColumn.Name = "klijentIDDataGridViewTextBoxColumn";
            this.klijentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.klijentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godinaRodjenjaDataGridViewTextBoxColumn
            // 
            this.godinaRodjenjaDataGridViewTextBoxColumn.DataPropertyName = "GodinaRodjenja";
            this.godinaRodjenjaDataGridViewTextBoxColumn.HeaderText = "Godina rođenja";
            this.godinaRodjenjaDataGridViewTextBoxColumn.Name = "godinaRodjenjaDataGridViewTextBoxColumn";
            this.godinaRodjenjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.godinaRodjenjaDataGridViewTextBoxColumn.Width = 110;
            // 
            // kategorijaBEDataGridViewCheckBoxColumn
            // 
            this.kategorijaBEDataGridViewCheckBoxColumn.DataPropertyName = "KategorijaBE";
            this.kategorijaBEDataGridViewCheckBoxColumn.HeaderText = "Kategorija B+E";
            this.kategorijaBEDataGridViewCheckBoxColumn.Name = "kategorijaBEDataGridViewCheckBoxColumn";
            this.kategorijaBEDataGridViewCheckBoxColumn.ReadOnly = true;
            this.kategorijaBEDataGridViewCheckBoxColumn.Width = 90;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail adresa";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobitelDataGridViewTextBoxColumn
            // 
            this.mobitelDataGridViewTextBoxColumn.DataPropertyName = "Mobitel";
            this.mobitelDataGridViewTextBoxColumn.HeaderText = "Broj mobitela";
            this.mobitelDataGridViewTextBoxColumn.Name = "mobitelDataGridViewTextBoxColumn";
            this.mobitelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezervacijeDataGridViewTextBoxColumn
            // 
            this.rezervacijeDataGridViewTextBoxColumn.DataPropertyName = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.HeaderText = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.Name = "rezervacijeDataGridViewTextBoxColumn";
            this.rezervacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // klijentiBindingSource
            // 
            this.klijentiBindingSource.DataSource = typeof(NajamAutaEF.Klijenti);
            // 
            // btnNoviKlijent
            // 
            this.btnNoviKlijent.Location = new System.Drawing.Point(135, 241);
            this.btnNoviKlijent.Name = "btnNoviKlijent";
            this.btnNoviKlijent.Size = new System.Drawing.Size(114, 25);
            this.btnNoviKlijent.TabIndex = 1;
            this.btnNoviKlijent.Text = "Unesi novog klijenta";
            this.btnNoviKlijent.UseVisualStyleBackColor = true;
            this.btnNoviKlijent.Click += new System.EventHandler(this.btnNoviKlijent_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(381, 241);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(114, 25);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši klijenta";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // PopisKlijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 278);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNoviKlijent);
            this.Controls.Add(this.dgvKlijenti);
            this.Name = "PopisKlijenata";
            this.Text = "PopisKlijenata";
            this.Load += new System.EventHandler(this.PopisKlijenata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klijentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKlijenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaRodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kategorijaBEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource klijentiBindingSource;
        private System.Windows.Forms.Button btnNoviKlijent;
        private System.Windows.Forms.Button btnObrisi;
    }
}