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
    public partial class NovaPrikolica : Form
    {
        private bool be { get; set; }
        public NovaPrikolica()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (beCheckBox.Checked == true)
            {
                be = true;
            }
            if (beCheckBox.Checked == false)
            {
                be = false;
            }
            using (var db = new RentacarEntities())
            {
                Prikolice prikolica = new Prikolice
                {
                    TipPrikolice = tipPrikoliceTextBox.Text,
                    BrojOsovina = int.Parse(brojOsovinaComboBox.SelectedItem.ToString()),
                    DnevniNajam = int.Parse(dnevniNajamTextBox.Text),
                    PotrebaBE = be,
                    Rezervirana = false
                };
                db.Prikolice.Add(prikolica);
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
