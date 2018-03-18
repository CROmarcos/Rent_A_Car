namespace NajamAutaEF
{
    partial class PopisVozila
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
            this.btnNoviAuto = new System.Windows.Forms.Button();
            this.btnObrisiAuto = new System.Windows.Forms.Button();
            this.voziloIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.godisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gorivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojSjedalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kukaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dnevniNajamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezerviranDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rezervacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voziloIDDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.godisteDataGridViewTextBoxColumn,
            this.gorivoDataGridViewTextBoxColumn,
            this.brojSjedalaDataGridViewTextBoxColumn,
            this.kukaDataGridViewCheckBoxColumn,
            this.dnevniNajamDataGridViewTextBoxColumn,
            this.rezerviranDataGridViewCheckBoxColumn,
            this.rezervacijeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vozilaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 187);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnNoviAuto
            // 
            this.btnNoviAuto.Location = new System.Drawing.Point(234, 221);
            this.btnNoviAuto.Name = "btnNoviAuto";
            this.btnNoviAuto.Size = new System.Drawing.Size(126, 27);
            this.btnNoviAuto.TabIndex = 1;
            this.btnNoviAuto.Text = "Dodaj novo vozilo";
            this.btnNoviAuto.UseVisualStyleBackColor = true;
            this.btnNoviAuto.Click += new System.EventHandler(this.btnNoviAuto_Click);
            // 
            // btnObrisiAuto
            // 
            this.btnObrisiAuto.Location = new System.Drawing.Point(496, 221);
            this.btnObrisiAuto.Name = "btnObrisiAuto";
            this.btnObrisiAuto.Size = new System.Drawing.Size(126, 27);
            this.btnObrisiAuto.TabIndex = 2;
            this.btnObrisiAuto.Text = "Obriši vozilo iz sustava";
            this.btnObrisiAuto.UseVisualStyleBackColor = true;
            this.btnObrisiAuto.Click += new System.EventHandler(this.btnObrisiAuto_Click);
            // 
            // voziloIDDataGridViewTextBoxColumn
            // 
            this.voziloIDDataGridViewTextBoxColumn.DataPropertyName = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.HeaderText = "VoziloID";
            this.voziloIDDataGridViewTextBoxColumn.Name = "voziloIDDataGridViewTextBoxColumn";
            this.voziloIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.voziloIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "Marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "Marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            this.markaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // godisteDataGridViewTextBoxColumn
            // 
            this.godisteDataGridViewTextBoxColumn.DataPropertyName = "Godiste";
            this.godisteDataGridViewTextBoxColumn.HeaderText = "Godište";
            this.godisteDataGridViewTextBoxColumn.Name = "godisteDataGridViewTextBoxColumn";
            this.godisteDataGridViewTextBoxColumn.ReadOnly = true;
            this.godisteDataGridViewTextBoxColumn.Width = 70;
            // 
            // gorivoDataGridViewTextBoxColumn
            // 
            this.gorivoDataGridViewTextBoxColumn.DataPropertyName = "Gorivo";
            this.gorivoDataGridViewTextBoxColumn.HeaderText = "Gorivo";
            this.gorivoDataGridViewTextBoxColumn.Name = "gorivoDataGridViewTextBoxColumn";
            this.gorivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojSjedalaDataGridViewTextBoxColumn
            // 
            this.brojSjedalaDataGridViewTextBoxColumn.DataPropertyName = "BrojSjedala";
            this.brojSjedalaDataGridViewTextBoxColumn.HeaderText = "Broj sjedala";
            this.brojSjedalaDataGridViewTextBoxColumn.Name = "brojSjedalaDataGridViewTextBoxColumn";
            this.brojSjedalaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kukaDataGridViewCheckBoxColumn
            // 
            this.kukaDataGridViewCheckBoxColumn.DataPropertyName = "Kuka";
            this.kukaDataGridViewCheckBoxColumn.HeaderText = "Kuka";
            this.kukaDataGridViewCheckBoxColumn.Name = "kukaDataGridViewCheckBoxColumn";
            this.kukaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.kukaDataGridViewCheckBoxColumn.Width = 60;
            // 
            // dnevniNajamDataGridViewTextBoxColumn
            // 
            this.dnevniNajamDataGridViewTextBoxColumn.DataPropertyName = "DnevniNajam";
            this.dnevniNajamDataGridViewTextBoxColumn.HeaderText = "Iznos dnevnog najma (HRK)";
            this.dnevniNajamDataGridViewTextBoxColumn.Name = "dnevniNajamDataGridViewTextBoxColumn";
            this.dnevniNajamDataGridViewTextBoxColumn.ReadOnly = true;
            this.dnevniNajamDataGridViewTextBoxColumn.Width = 180;
            // 
            // rezerviranDataGridViewCheckBoxColumn
            // 
            this.rezerviranDataGridViewCheckBoxColumn.DataPropertyName = "Rezerviran";
            this.rezerviranDataGridViewCheckBoxColumn.HeaderText = "Rezerviran";
            this.rezerviranDataGridViewCheckBoxColumn.Name = "rezerviranDataGridViewCheckBoxColumn";
            this.rezerviranDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // rezervacijeDataGridViewTextBoxColumn
            // 
            this.rezervacijeDataGridViewTextBoxColumn.DataPropertyName = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.HeaderText = "Rezervacije";
            this.rezervacijeDataGridViewTextBoxColumn.Name = "rezervacijeDataGridViewTextBoxColumn";
            this.rezervacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // vozilaBindingSource
            // 
            this.vozilaBindingSource.DataSource = typeof(NajamAutaEF.Vozila);
            // 
            // PopisVozila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 265);
            this.Controls.Add(this.btnObrisiAuto);
            this.Controls.Add(this.btnNoviAuto);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PopisVozila";
            this.Text = "Vozila raspoloživa za iznajmljivanje";
            this.Load += new System.EventHandler(this.PopisVozila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vozilaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn voziloIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gorivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojSjedalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kukaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnevniNajamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rezerviranDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vozilaBindingSource;
        private System.Windows.Forms.Button btnNoviAuto;
        private System.Windows.Forms.Button btnObrisiAuto;
    }
}