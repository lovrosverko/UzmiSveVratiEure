using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UzmiSveVratiEure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            txtPlacenoEUR.Clear();
            txtPlacenoKN.Clear();
            txtPlacenoUkupno.Clear();
            txtRacunEUR.Clear();
            txtVratiti.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            double euro = 7.5345;
            double eurRacun, knPlaceno, eurPlaceno,
                placenoTotEUR, placenoTotKn, vratitiTotEUR,
                vratitiTotKn;
            try
            {
                if (txtPlacenoEUR.Text == "")
                {
                    eurPlaceno = 0;
                    txtPlacenoEUR.Text = "0,00 €";
                }
                else
                {
                    eurPlaceno = Convert.ToDouble(txtPlacenoEUR.Text);
                    txtPlacenoEUR.Text = eurPlaceno.ToString("F", CultureInfo.InvariantCulture) 
                        + " €";
                }
                if (txtPlacenoKN.Text == "")
                {
                    knPlaceno = 0;
                    txtPlacenoKN.Text = "0,00 Kn";
                }
                else
                {
                    knPlaceno = Convert.ToDouble(txtPlacenoKN.Text);
                    txtPlacenoKN.Text = knPlaceno.ToString("F", CultureInfo.InvariantCulture)
                        + " kn";
                }
                if (txtRacunEUR.Text == "")
                {
                    eurRacun = 0;
                    txtRacunEUR.Text = "0,00 €";
                }
                else
                {
                    eurRacun = Convert.ToDouble(txtRacunEUR.Text);
                    txtRacunEUR.Text = eurRacun.ToString("F",
                  CultureInfo.InvariantCulture) + " €";
                }
                placenoTotEUR = Math.Round((knPlaceno / euro),2) + eurPlaceno;
                placenoTotKn = knPlaceno + Math.Round((eurPlaceno * euro),2);
                string placeno = placenoTotEUR.ToString("F",
                  CultureInfo.InvariantCulture) + " € ("+ placenoTotKn.ToString("F",
                  CultureInfo.InvariantCulture) +" kn)";
                txtPlacenoUkupno.Text = placeno;

                vratitiTotEUR = placenoTotEUR - eurRacun;
                vratitiTotKn = placenoTotKn - Math.Round((eurRacun*euro), 2);
                string vratiti = vratitiTotEUR.ToString("F",
                  CultureInfo.InvariantCulture) + " € (" 
                    + vratitiTotKn.ToString("F",
                  CultureInfo.InvariantCulture) + " kn)";
                txtVratiti.Text = vratiti;
                if (vratitiTotEUR < 0)
                {
                    txtVratiti.ForeColor = Color.Red;
                }
            }
            catch
            {
                MessageBox.Show("Molim provjerite unos podataka.",
                    "Pogrešan unos!", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error );
            }
        }
    }
}
