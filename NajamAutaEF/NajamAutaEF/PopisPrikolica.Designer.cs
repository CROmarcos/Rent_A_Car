namespace NajamAutaEF
{
    partial class PopisPrikolica
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
            this.dgvPrikolice = new System.Windows.Forms.DataGridView();
            this.prikolicaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipPrikoliceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojOsovinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dnevniNajamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.potrebaBEDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rezerviranaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prikoliceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajPrikolicu = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikolice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikoliceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrikolice
            // 
            this.dgvPrikolice.AllowUserToAddRows = false;
            this.dgvPrikolice.AllowUserToDeleteRows = false;
            this.dgvPrikolice.AutoGenerateColumns = false;
            this.dgvPrikolice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikolice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prikolicaIDDataGridViewTextBoxColumn,
            this.tipPrikoliceDataGridViewTextBoxColumn,
            this.brojOsovinaDataGridViewTextBoxColumn,
            this.dnevniNajamDataGridViewTextBoxColumn,
            this.potrebaBEDataGridViewCheckBoxColumn,
            this.rezerviranaDataGridViewCheckBoxColumn,
            this.rezervacijeDataGridViewTextBoxColumn});
            this.dgvPrikolice.DataSource = this.prikoliceBindingSource;
            this.dgvPrikolice.Location = new System.Drawing.Point(12, 12);
            this.dgvPrikolice.Name = "dgvPrikolice";
            this.dgvPrikolice.ReadOnly = true;
            this.dgvPrikolice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrikolice.Size = new System.Drawing.Size(654, 190);
            this.dgvPrikolice.TabIndex = 0;
            // 
            // prikolicaIDDataGridViewTextBoxColumn
            // 
            this.prikolicaIDDataGridViewTextBoxColumn.DataPropertyName = "PrikolicaID";
            this.prikolicaIDDataGridViewTextBoxColumn.HeaderText = "PrikolicaID";
            this.prikolicaIDDataGridViewTextBoxColumn.Name = "prikolicaIDDataGridViewTextBoxColumn";
            this.prikolicaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.prikolicaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipPrikoliceDataGridViewTextBoxColumn
            // 
            this.tipPrikoliceDataGridViewTextBoxColumn.DataPropertyName = "TipPrikolice";
            this.tipPrikoliceDataGridViewTextBoxColumn.HeaderText = "Tip prikolice";
            this.tipPrikoliceDataGridViewTextBoxColumn.Name = "tipPrikoliceDataGridViewTextBoxColumn";
            this.tipPrikoliceDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipPrikoliceDataGridViewTextBoxColumn.Width = 150;
            // 
            // brojOsovinaDataGridViewTextBoxColumn
            // 
            this.brojOsovinaDataGridViewTextBoxColumn.DataPropertyName = "BrojOsovina";
            this.brojOsovinaDataGridViewTextBoxColumn.HeaderText = "Broj osovina";
            this.brojOsovinaDataGridViewTextBoxColumn.Name = "brojOsovinaDataGridViewTextBoxColumn";
            this.brojOsovinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.brojOsovinaDataGridViewTextBoxColumn.Width = 90;
            // 
            // dnevniNajamDataGridViewTextBoxColumn
            // 
            this.dnevniNajamDataGridViewTextBoxColumn.DataPropertyName = "DnevniNajam";
            this.dnevniNajamDataGridViewTextBoxColumn.HeaderText = "Iznos dnevnog najma (HRK)";
            this.dnevniNajamDataGridViewTextBoxColumn.Name = "dnevniNajamDataGridViewTextBoxColumn";
            this.dnevniNajamDataGridViewTextBoxColumn.ReadOnly = true;
            this.dnevniNajamDataGridViewTextBoxColumn.Width = 200;
            // 
            // potrebaBEDataGridViewCheckBoxColumn
            // 
            this.potrebaBEDataGridViewCheckBoxColumn.DataPropertyName = "PotrebaBE";
            this.potrebaBEDataGridViewCheckBoxColumn.HeaderText = "Potreba B+E";
            this.potrebaBEDataGridViewCheckBoxColumn.Name = "potrebaBEDataGridViewCheckBoxColumn";
            this.potrebaBEDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rezerviranaDataGridViewCheckBoxColumn
            // 
            this.rezerviranaDataGridViewCheckBoxColumn.DataPropertyName = "Rezervirana";
            this.rezerviranaDataGridViewCheckBoxColumn.HeaderText = "Rezervirana";
            this.rezerviranaDataGridViewCheckBoxColumn.Name = "rezerviranaDataGridViewCheckBoxColumn";
            this.rezerviranaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.rezerviranaDataGridViewCheckBoxColumn.Width = 70;
            // 
            // rezervacijeDataGridViewTextBoxColumn
            // 
            this.rezervacijeDataGridViewTextBoxColumn.DataPropertyName = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.HeaderText = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.Name = "rezervacijeDataGridViewTextBoxColumn";
            this.rezervacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // prikoliceBindingSource
            // 
            this.prikoliceBindingSource.DataSource = typeof(NajamAutaEF.Prikolice);
            // 
            // btnDodajPrikolicu
            // 
            this.btnDodajPrikolicu.Location = new System.Drawing.Point(138, 220);
            this.btnDodajPrikolicu.Name = "btnDodajPrikolicu";
            this.btnDodajPrikolicu.Size = new System.Drawing.Size(125, 24);
            this.btnDodajPrikolicu.TabIndex = 1;
            this.btnDodajPrikolicu.Text = "Dodaj novu prikolicu";
            this.btnDodajPrikolicu.UseVisualStyleBackColor = true;
            this.btnDodajPrikolicu.Click += new System.EventHandler(this.btnDodajPrikolicu_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(379, 220);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(125, 24);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obriši prikolicu";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // PopisPrikolica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 265);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodajPrikolicu);
            this.Controls.Add(this.dgvPrikolice);
            this.Name = "PopisPrikolica";
            this.Text = "PopisPrikolica";
            this.Load += new System.EventHandler(this.PopisPrikolica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikolice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prikoliceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrikolice;
        private System.Windows.Forms.DataGridViewTextBoxColumn prikolicaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipPrikoliceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojOsovinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnevniNajamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn potrebaBEDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rezerviranaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource prikoliceBindingSource;
        private System.Windows.Forms.Button btnDodajPrikolicu;
        private System.Windows.Forms.Button btnObrisi;
    }
}