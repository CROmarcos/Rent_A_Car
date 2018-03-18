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
    public partial class NovaRezervacija : Form
    {
        public NovaRezervacija()
        {
            InitializeComponent();
        }

        private void PopuniCombobox()
        {
            BindingList<Klijenti> listaKlijenata = null;
            BindingList<Lokacije> listaLokacija = null;
            BindingList<Vozila> listaVozila = null;
            BindingList<Prikolice> listaPrikolica = null;
            using (var db = new RentacarEntities())
            {
                listaKlijenata = new BindingList<Klijenti>(db.Klijenti.ToList());
                listaLokacija = new BindingList<Lokacije>(db.Lokacije.ToList());
                listaVozila = new BindingList<Vozila>(db.Vozila.ToList());
                listaPrikolica = new BindingList<Prikolice>(db.Prikolice.ToList());
            }
            klijentComboBox.DataSource = listaKlijenata;
            lokacijaComboBox.DataSource = listaLokacija;
            voziloComboBox.DataSource = listaVozila;
            prikolicaComboBox.DataSource = listaPrikolica;
        }

        private void NovaRezervacija_Load(object sender, EventArgs e)
        {
            PopuniCombobox();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new RentacarEntities())
            {
                Rezervacije rezervacija = new Rezervacije
                {
                    Klijent = int.Parse(klijentComboBox.SelectedItem.ToString()),
                    Lokacija = int.Parse(lokacijaComboBox.SelectedItem.ToString()),
                    Vozilo = int.Parse(voziloComboBox.SelectedItem.ToString()),
                    Prikolica = null,
                    PocetakPosudbe = DateTime.Today.Date,
                    IstekPosudbe = istekPosudbeDateTimePicker.Value.Date
                };
                rezervacija.CijenaPosudbe = rezervacija.IzracunajCijenu();
                db.Rezervacije.Add(rezervacija);
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
