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
    public partial class PopisLokacija : Form
    {
        public PopisLokacija()
        {
            InitializeComponent();
        }

        private void PrikaziLokacije()
        {
            BindingList<Lokacije> lista = null;
            using (var db = new RentacarEntities())
            {
                lista = new BindingList<Lokacije>(db.Lokacije.ToList());
            }
            lokacijeBindingSource.DataSource = lista;
        }

        private void PopisLokacija_Load(object sender, EventArgs e)
        {
            PrikaziLokacije();
        }

        private void btnDodajLokaciju_Click(object sender, EventArgs e)
        {
            NovaLokacija forma = new NovaLokacija();
            forma.ShowDialog();
            PrikaziLokacije();
        }

        private void btnObrisiLokaciju_Click(object sender, EventArgs e)
        {
            Lokacije lokacija = lokacijeBindingSource.Current as Lokacije;
            if (lokacija != null)
            {
                using (var db = new RentacarEntities())
                {
                    db.Lokacije.Attach(lokacija);
                    db.Lokacije.Remove(lokacija);
                    db.SaveChanges();
                }
            }
            PrikaziLokacije();
        }
    }
}
