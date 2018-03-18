namespace NajamAutaEF
{
    partial class GlavnaForma
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
            this.btnLokacije = new System.Windows.Forms.Button();
            this.btnVozila = new System.Windows.Forms.Button();
            this.btnPrikolice = new System.Windows.Forms.Button();
            this.btnKlijenti = new System.Windows.Forms.Button();
            this.btnNovaRezervacija = new System.Windows.Forms.Button();
            this.btnPopisRezervacija = new System.Windows.Forms.Button();
            this.abcd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLokacije
            // 
            this.btnLokacije.Location = new System.Drawing.Point(67, 35);
            this.btnLokacije.Name = "btnLokacije";
            this.btnLokacije.Size = new System.Drawing.Size(88, 48);
            this.btnLokacije.TabIndex = 0;
            this.btnLokacije.Text = "Popis auto-salona";
            this.btnLokacije.UseVisualStyleBackColor = true;
            this.btnLokacije.Click += new System.EventHandler(this.btnLokacije_Click);
            // 
            // btnVozila
            // 
            this.btnVozila.Location = new System.Drawing.Point(234, 35);
            this.btnVozila.Name = "btnVozila";
            this.btnVozila.Size = new System.Drawing.Size(88, 48);
            this.btnVozila.TabIndex = 1;
            this.btnVozila.Text = "Popis vozila";
            this.btnVozila.UseVisualStyleBackColor = true;
            this.btnVozila.Click += new System.EventHandler(this.btnVozila_Click);
            // 
            // btnPrikolice
            // 
            this.btnPrikolice.Location = new System.Drawing.Point(67, 120);
            this.btnPrikolice.Name = "btnPrikolice";
            this.btnPrikolice.Size = new System.Drawing.Size(88, 48);
            this.btnPrikolice.TabIndex = 2;
            this.btnPrikolice.Text = "Popis prikolica";
            this.btnPrikolice.UseVisualStyleBackColor = true;
            this.btnPrikolice.Click += new System.EventHandler(this.btnPrikolice_Click);
            // 
            // btnKlijenti
            // 
            this.btnKlijenti.Location = new System.Drawing.Point(234, 120);
            this.btnKlijenti.Name = "btnKlijenti";
            this.btnKlijenti.Size = new System.Drawing.Size(88, 48);
            this.btnKlijenti.TabIndex = 3;
            this.btnKlijenti.Text = "Popis klijenata";
            this.btnKlijenti.UseVisualStyleBackColor = true;
            this.btnKlijenti.Click += new System.EventHandler(this.btnKlijenti_Click);
            // 
            // btnNovaRezervacija
            // 
            this.btnNovaRezervacija.Location = new System.Drawing.Point(97, 221);
            this.btnNovaRezervacija.Name = "btnNovaRezervacija";
            this.btnNovaRezervacija.Size = new System.Drawing.Size(196, 33);
            this.btnNovaRezervacija.TabIndex = 4;
            this.btnNovaRezervacija.Text = "Izradi novu rezervaciju";
            this.btnNovaRezervacija.UseVisualStyleBackColor = true;
            this.btnNovaRezervacija.Click += new System.EventHandler(this.btnNovaRezervacija_Click);
            // 
            // btnPopisRezervacija
            // 
            this.btnPopisRezervacija.Location = new System.Drawing.Point(234, 297);
            this.btnPopisRezervacija.Name = "btnPopisRezervacija";
            this.btnPopisRezervacija.Size = new System.Drawing.Size(137, 26);
            this.btnPopisRezervacija.TabIndex = 5;
            this.btnPopisRezervacija.Text = "Popis aktivnih rezervacija";
            this.btnPopisRezervacija.UseVisualStyleBackColor = true;
            this.btnPopisRezervacija.Click += new System.EventHandler(this.btnPopisRezervacija_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(383, 335);
            this.Controls.Add(this.abcd);
            this.Controls.Add(this.btnPopisRezervacija);
            this.Controls.Add(this.btnNovaRezervacija);
            this.Controls.Add(this.btnKlijenti);
            this.Controls.Add(this.btnPrikolice);
            this.Controls.Add(this.btnVozila);
            this.Controls.Add(this.btnLokacije);
            this.Name = "GlavnaForma";
            this.Text = "Rent-A-Car";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLokacije;
        private System.Windows.Forms.Button btnVozila;
        private System.Windows.Forms.Button btnPrikolice;
        private System.Windows.Forms.Button btnKlijenti;
        private System.Windows.Forms.Button btnNovaRezervacija;
        private System.Windows.Forms.Button btnPopisRezervacija;
        private System.Windows.Forms.Button abcd;
    }
}

