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
    public partial class NovaLokacija : Form
    {
        public NovaLokacija()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new RentacarEntities())
            {
                Lokacije lokacija = new Lokacije
                {
                    Zupanija = zupanijaTextBox.Text,
                    Grad = gradTextBox.Text,
                    Adresa = adresaTextBox.Text,
                    CijenaDovoza = int.Parse(cijenaDovozaTextBox.Text)
                };
                db.Lokacije.Add(lokacija);
                db.SaveChanges();
            }
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
