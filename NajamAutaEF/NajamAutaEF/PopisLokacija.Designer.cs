namespace NajamAutaEF
{
    partial class PopisLokacija
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
            this.dgvLokacije = new System.Windows.Forms.DataGridView();
            this.lokacijaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zupanijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDovozaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokacijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajLokaciju = new System.Windows.Forms.Button();
            this.btnObrisiLokaciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLokacije
            // 
            this.dgvLokacije.AllowUserToAddRows = false;
            this.dgvLokacije.AllowUserToDeleteRows = false;
            this.dgvLokacije.AutoGenerateColumns = false;
            this.dgvLokacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLokacije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lokacijaIDDataGridViewTextBoxColumn,
            this.zupanijaDataGridViewTextBoxColumn,
            this.gradDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.cijenaDovozaDataGridViewTextBoxColumn,
            this.rezervacijeDataGridViewTextBoxColumn});
            this.dgvLokacije.DataSource = this.lokacijeBindingSource;
            this.dgvLokacije.Location = new System.Drawing.Point(13, 13);
            this.dgvLokacije.Name = "dgvLokacije";
            this.dgvLokacije.ReadOnly = true;
            this.dgvLokacije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLokacije.Size = new System.Drawing.Size(575, 199);
            this.dgvLokacije.TabIndex = 0;
            // 
            // lokacijaIDDataGridViewTextBoxColumn
            // 
            this.lokacijaIDDataGridViewTextBoxColumn.DataPropertyName = "LokacijaID";
            this.lokacijaIDDataGridViewTextBoxColumn.HeaderText = "LokacijaID";
            this.lokacijaIDDataGridViewTextBoxColumn.Name = "lokacijaIDDataGridViewTextBoxColumn";
            this.lokacijaIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lokacijaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // zupanijaDataGridViewTextBoxColumn
            // 
            this.zupanijaDataGridViewTextBoxColumn.DataPropertyName = "Zupanija";
            this.zupanijaDataGridViewTextBoxColumn.HeaderText = "Županija";
            this.zupanijaDataGridViewTextBoxColumn.Name = "zupanijaDataGridViewTextBoxColumn";
            this.zupanijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradDataGridViewTextBoxColumn
            // 
            this.gradDataGridViewTextBoxColumn.DataPropertyName = "Grad";
            this.gradDataGridViewTextBoxColumn.HeaderText = "Grad";
            this.gradDataGridViewTextBoxColumn.Name = "gradDataGridViewTextBoxColumn";
            this.gradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.adresaDataGridViewTextBoxColumn.Width = 200;
            // 
            // cijenaDovozaDataGridViewTextBoxColumn
            // 
            this.cijenaDovozaDataGridViewTextBoxColumn.DataPropertyName = "CijenaDovoza";
            this.cijenaDovozaDataGridViewTextBoxColumn.HeaderText = "Cijena dovoza (HRK)";
            this.cijenaDovozaDataGridViewTextBoxColumn.Name = "cijenaDovozaDataGridViewTextBoxColumn";
            this.cijenaDovozaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaDovozaDataGridViewTextBoxColumn.Width = 130;
            // 
            // rezervacijeDataGridViewTextBoxColumn
            // 
            this.rezervacijeDataGridViewTextBoxColumn.DataPropertyName = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.HeaderText = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.Name = "rezervacijeDataGridViewTextBoxColumn";
            this.rezervacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // lokacijeBindingSource
            // 
            this.lokacijeBindingSource.DataSource = typeof(NajamAutaEF.Lokacije);
            // 
            // btnDodajLokaciju
            // 
            this.btnDodajLokaciju.Location = new System.Drawing.Point(77, 225);
            this.btnDodajLokaciju.Name = "btnDodajLokaciju";
            this.btnDodajLokaciju.Size = new System.Drawing.Size(133, 25);
            this.btnDodajLokaciju.TabIndex = 1;
            this.btnDodajLokaciju.Text = "Dodaj novu lokaciju";
            this.btnDodajLokaciju.UseVisualStyleBackColor = true;
            this.btnDodajLokaciju.Click += new System.EventHandler(this.btnDodajLokaciju_Click);
            // 
            // btnObrisiLokaciju
            // 
            this.btnObrisiLokaciju.Location = new System.Drawing.Point(376, 225);
            this.btnObrisiLokaciju.Name = "btnObrisiLokaciju";
            this.btnObrisiLokaciju.Size = new System.Drawing.Size(133, 25);
            this.btnObrisiLokaciju.TabIndex = 2;
            this.btnObrisiLokaciju.Text = "Obriši lokaciju";
            this.btnObrisiLokaciju.UseVisualStyleBackColor = true;
            this.btnObrisiLokaciju.Click += new System.EventHandler(this.btnObrisiLokaciju_Click);
            // 
            // PopisLokacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 264);
            this.Controls.Add(this.btnObrisiLokaciju);
            this.Controls.Add(this.btnDodajLokaciju);
            this.Controls.Add(this.dgvLokacije);
            this.Name = "PopisLokacija";
            this.Text = "Lokacije preuzimanja vozila";
            this.Load += new System.EventHandler(this.PopisLokacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLokacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lokacijeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLokacije;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokacijaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zupanijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDovozaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lokacijeBindingSource;
        private System.Windows.Forms.Button btnDodajLokaciju;
        private System.Windows.Forms.Button btnObrisiLokaciju;
    }
}