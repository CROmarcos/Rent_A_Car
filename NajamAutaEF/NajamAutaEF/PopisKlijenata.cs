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
    public partial class PopisKlijenata : Form
    {
        public PopisKlijenata()
        {
            InitializeComponent();
        }

        private void PrikaziKlijente()
        {
            BindingList<Klijenti> lista = null;
            using (var db = new RentacarEntities())
            {
                lista = new BindingList<Klijenti>(db.Klijenti.ToList());
            }
            klijentiBindingSource.DataSource = lista;
        }

        private void PopisKlijenata_Load(object sender, EventArgs e)
        {
            PrikaziKlijente();
        }

        private void btnNoviKlijent_Click(object sender, EventArgs e)
        {
            NoviKlijent forma = new NoviKlijent();
            forma.ShowDialog();
            PrikaziKlijente();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Klijenti klijent = klijentiBindingSource.Current as Klijenti;
            if (klijent != null)
            {
                if (MessageBox.Show("Sigurno želite obrisati klijenta?", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new RentacarEntities())
                    {
                        db.Klijenti.Attach(klijent);
                        db.Klijenti.Remove(klijent);
                        db.SaveChanges();
                    }
                }
            }
            PrikaziKlijente();
        }
    }
}
