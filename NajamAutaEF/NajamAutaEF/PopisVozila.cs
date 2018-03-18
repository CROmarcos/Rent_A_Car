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
    public partial class PopisVozila : Form
    {
        public PopisVozila()
        {
            InitializeComponent();
        }

        private void PrikaziVozila()
        {
            BindingList<Vozila> lista = null;
            using (var db = new RentacarEntities())
            {
                lista = new BindingList<Vozila>(db.Vozila.ToList());
            }
            vozilaBindingSource.DataSource = lista;
        }

        private void PopisVozila_Load(object sender, EventArgs e)
        {
            PrikaziVozila();
        }

        private void btnNoviAuto_Click(object sender, EventArgs e)
        {
            NovoVozilo forma = new NovoVozilo();
            forma.ShowDialog();
        }

        private void btnObrisiAuto_Click(object sender, EventArgs e)
        {
            Vozila vozilo = vozilaBindingSource.Current as Vozila;
            if (vozilo != null)
            {
                using (var db = new RentacarEntities())
                {
                    db.Vozila.Attach(vozilo);
                    db.Vozila.Remove(vozilo);
                    db.SaveChanges();
                }
            }
            PrikaziVozila();
        }
    }
}
