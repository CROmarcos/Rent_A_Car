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
    public partial class PopisRezervacija : Form
    {
        public PopisRezervacija()
        {
            InitializeComponent();
        }

        public void PrikaziRezervacije()
        {
            BindingList<Rezervacije> lista = null;
            using (var db = new RentacarEntities())
            {
                lista = new BindingList<Rezervacije>(db.Rezervacije.ToList());
            }
            dgvRezervacije.DataSource = lista;
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {

        }

        private void PopisRezervacija_Load(object sender, EventArgs e)
        {
            PrikaziRezervacije();
        }
    }
}
