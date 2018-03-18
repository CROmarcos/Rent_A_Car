using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NajamAutaEF
{
    public partial class NovoVozilo : Form
    {
        private bool kuka;
        public NovoVozilo()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (rbDa.Checked == true)
            {
                kuka = true;
            }
            if (rbNe.Checked == true)
            {
                kuka = false;
            }
            using (var db = new RentacarEntities())
            {
                Vozila vozilo = new Vozila
                {
                    Marka = markaTextBox.Text,
                    Model = modelTextBox.Text,
                    Godiste = int.Parse(godisteComboBox.SelectedItem.ToString()),
                    Gorivo = gorivoComboBox.SelectedItem.ToString(),
                    BrojSjedala = int.Parse(brojSjedalaTextBox.Text.ToString()),
                    DnevniNajam = Convert.ToDecimal(dnevniNajamTextBox.Text),
                    Kuka = kuka,
                    Rezerviran = false
                };
                db.Vozila.Add(vozilo);
                db.SaveChanges();
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NovoVozilo_Load(object sender, EventArgs e)
        {
            rbNe.Checked = true;
            for (int i = 1970; i <= 2018; i++)
            {
                godisteComboBox.Items.Add(i);
            }
        }
    }
}
