using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertSoczewki1
{
    public partial class Wynik : Form
    {
        public Wynik()
        {
            InitializeComponent();
        }

        private void buttonPowrotdoKNN_Click(object sender, EventArgs e)
        {
            Knn knn = new Knn();
            knn.Show();
            this.Hide();
        }

        private void Wynik_Load(object sender, EventArgs e)
        {
            
            string wynik = Knn.wynik;
            labelWynik.Text = wynik; // wyswietlenie wyniku diagnozy
            // wyswietlanie logów
            string logi = Knn.logi;
            for (int i = 0; i < Knn.iloscWierszy; i++)
            {

                for (int j = 0; j < Knn.iloscKolumn; j++)
                {
                    logi += Convert.ToString(Knn.tabelaDanych[i, j]) + "    ";
                }

                logi += " Odległość = " + Knn.ObliczoneOdleglosci[i] + "\r\n";

            }
            logi += "\r\n";
            logi += "Najmniejsza odległość: " + Knn.najmniejszaOdleglosc  +"\r\n";
            logi += "Najbliższy sąsiad: \r\n" + Knn.naglowki + "\r\n";
            for (int i = 0; i < Knn.iloscKolumn; i++)
            {
                logi += Convert.ToString(Knn.tabelaDanych[Knn.nrWierszaPozycji, i]) + "    ";
            }

            textBoxLog.Text = logi;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
