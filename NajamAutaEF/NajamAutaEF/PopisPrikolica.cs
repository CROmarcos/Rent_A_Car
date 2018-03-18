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
    public partial class PopisPrikolica : Form
    {
        public PopisPrikolica()
        {
            InitializeComponent();
        }

        private void PrikaziPrikolice()
        {
            BindingList<Prikolice> lista = null;
            using (var db = new RentacarEntities())
            {
                lista = new BindingList<Prikolice>(db.Prikolice.ToList());                
            }
            dgvPrikolice.DataSource = lista;
        }

        private void PopisPrikolica_Load(object sender, EventArgs e)
        {
            PrikaziPrikolice();
        }

        private void btnDodajPrikolicu_Click(object sender, EventArgs e)
        {
            NovaPrikolica forma = new NovaPrikolica();
            forma.ShowDialog();
            PrikaziPrikolice();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (prikoliceBindingSource.Current is Prikolice prikolica)
            {
                using (var db = new RentacarEntities())
                {
                    db.Prikolice.Attach(prikolica);
                    db.Prikolice.Remove(prikolica);
                    db.SaveChanges();
                }
            }
            PrikaziPrikolice();
        }
    }
}
