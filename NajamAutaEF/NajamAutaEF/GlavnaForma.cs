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
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
            using (var db = new RentacarEntities())
            {
                foreach (var item in db.Klijenti)
                {
                    item.Ucitaj();
                }
                foreach (var item in db.Vozila)
                {
                    item.Ucitaj();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopisLokacija forma = new PopisLokacija();
            forma.ShowDialog();
        }

        private void btnLokacije_Click(object sender, EventArgs e)
        {
            PopisLokacija forma = new PopisLokacija();
            forma.ShowDialog();
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            PopisVozila forma = new PopisVozila();
            forma.ShowDialog();
        }

        private void btnPrikolice_Click(object sender, EventArgs e)
        {
            PopisPrikolica forma = new PopisPrikolica();
            forma.ShowDialog();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            PopisKlijenata forma = new PopisKlijenata();
            forma.ShowDialog();
        }

        private void btnNovaRezervacija_Click(object sender, EventArgs e)
        {
            NovaRezervacija forma = new NovaRezervacija();
            forma.ShowDialog();
        }

        private void btnPopisRezervacija_Click(object sender, EventArgs e)
        {
            PopisRezervacija forma = new PopisRezervacija();
            forma.ShowDialog();
        }
    }
}
