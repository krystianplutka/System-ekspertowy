using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkspertSoczewki1
{
    public partial class Knn : Form
    {
        public Knn()
        {
            InitializeComponent();
            
        }
        public static string wynik = "";
        public static int iloscWierszy = 24;
        public static int iloscKolumn =6;
        public static string logi = "";
        public static double[,] tabelaDanych = new double[24, 6];
        public static double[] ObliczoneOdleglosci;
        public static double najmniejszaOdleglosc;
        public static int nrWierszaPozycji;
        public static string naglowki;


        private void Knn_Load(object sender, EventArgs e)
        {

              //tworzenie tablicy o rozmiarze odpowiednim do pliku wejściowego
            string[] TabelaNaglowki = new string[6] { "ID","A1", "A2", "A3", "A4", "Class" }; //tablica jednowymiarowa z naglowkami

            for (int i = 0; i < iloscKolumn; i++)
            {
                naglowki += Convert.ToString(TabelaNaglowki[i]) + "  ";
                    }
            logi += naglowki + "\r\n";


            var SciezkaPliku = (@"daneSoczewki.txt"); // sciezka do pliku z danymi

            using (StreamReader reader = new StreamReader(SciezkaPliku))
            {

                reader.BaseStream.Seek(0, SeekOrigin.Begin);  //kursor na początek pliku 


                //odczytywanie danych z pliku do tablicy dwuwymiarowej
                for (int i = 0; i < iloscWierszy; i++)
                {
                    var row = reader.ReadLine();
                    int j = 0;
                    foreach (var col in row.Split(' '))
                    {
                        if (!String.IsNullOrWhiteSpace(col))
                        {
                            Double.TryParse(col, out tabelaDanych[i, j]);
                            j++;
                        }
                    }
                }
            }
           
            






                    // wprowadzanie danych z tablicy do dataGridView
                this.dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = iloscKolumn;
                for (int i = 0; i < iloscKolumn; i++)
                {
                    dataGridView1.Columns[i].Name = TabelaNaglowki[i];
                }

                for (int i = 0; i < iloscWierszy; i++)
                {
                    string[] Tabeladanych = new string[iloscWierszy];
                    for (int j = 0; j < iloscKolumn; j++)
                    {
                        Tabeladanych[j] = Convert.ToString(tabelaDanych[i, j]);
                  

                }
                    dataGridView1.Rows.Add(Tabeladanych);
               
                string iloscDanych = Convert.ToString(iloscWierszy);
                this.labelIlośćDanych.Text = "Ilość danych w pliku uczącym: " + iloscDanych;
                
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

       
       
            private void buttonPowrotForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        
        private void buttonUruchom_Click(object sender, EventArgs e)
        {
           
           
            double atrybut1 = 0;
            double atrybut2 = 0;
            double atrybut3 = 0;
            double atrybut4 = 0;
            Boolean poprawnosc = true;



            //przypisanie podanych atrybutow przez uzytkownika
             if (textBoxAtrybut1.Text.Length > 0 && textBoxAtrybut2.Text.Length > 0 && textBoxAtrybut3.Text.Length > 0 && textBoxAtrybut4.Text.Length > 0)
             {
                 atrybut1 = Convert.ToDouble(textBoxAtrybut1.Text);
                 atrybut2 = Convert.ToDouble(textBoxAtrybut2.Text);
                 atrybut3 = Convert.ToDouble(textBoxAtrybut3.Text);
                 atrybut4 = Convert.ToDouble(textBoxAtrybut4.Text);
             }
             else poprawnosc = false;

          
            if (atrybut1 > 3 || atrybut1 < 1 || atrybut2 > 2 || atrybut2 < 1 || atrybut3 > 2 || atrybut3 < 1 || atrybut4 > 2 || atrybut4 < 1)
            {
                MessageBox.Show("Wprowadź prawidłowe wartości!");
                poprawnosc = false;
            }


            if (poprawnosc == true)
            {
                //zdefiniowanie tablic jednowymiarowych przechowujących kolumny z atrybutami 
                Double[] KolumnaAtrybut1 = new Double[iloscWierszy];
                Double[] KolumnaAtrybut2 = new Double[iloscWierszy];
                Double[] KolumnaAtrybut3 = new Double[iloscWierszy];
                Double[] KolumnaAtrybut4 = new Double[iloscWierszy];



                // wprowadzenie wartosci do tablic jednowymiarowych przechowujacych kolejne kolumny(atrybuty danych)
                for (int x = 0; x < iloscWierszy; x++)
                {
                    KolumnaAtrybut1[x] = double.Parse((String)dataGridView1.Rows[x].Cells[1].Value);
                   

                }
                for (int x = 0; x < iloscWierszy; x++)
                {
                    KolumnaAtrybut2[x] = double.Parse((String)dataGridView1.Rows[x].Cells[2].Value);

                }

                for (int x = 0; x < iloscWierszy; x++)
                {
                    KolumnaAtrybut3[x] = double.Parse((String)dataGridView1.Rows[x].Cells[3].Value);

                }

                for (int x = 0; x < iloscWierszy; x++)
                {
                    KolumnaAtrybut4[x] = double.Parse((String)dataGridView1.Rows[x].Cells[4].Value);

                }



                //zdefiniowanie tablicy jednowymiarowej przechowującej obliczone odległości


                    ObliczoneOdleglosci = new double[iloscWierszy];
                // obliczenie odleglosci euklidesowej dla każdego wiersza danych
                for (int y = 0; y < iloscWierszy; y++)
                {
                    ObliczoneOdleglosci[y] = Math.Round(Math.Sqrt(Math.Pow((KolumnaAtrybut1[y] - atrybut1), 2) + Math.Pow((KolumnaAtrybut2[y] - atrybut2), 2) + Math.Pow((KolumnaAtrybut3[y] - atrybut3), 2) + Math.Pow((KolumnaAtrybut4[y] - atrybut4), 2)),3);

                }




                // szukanie najmniejszej obliczonej odleglosci w tablicy 
                double NajmniejszaOdleglosc = ObliczoneOdleglosci[0];
                for (int i = 0; i < iloscWierszy; i++)
                {
                    NajmniejszaOdleglosc = Math.Min(NajmniejszaOdleglosc, ObliczoneOdleglosci[i]);
                }
                NajmniejszaOdleglosc = najmniejszaOdleglosc;
                // szukanie nr wiersza pozycji dla której została obliczona najmnniejsza odleglosc
                int nrWierszaOsobnika = 0;
                for (int i = 0; i < iloscWierszy; i++)
                {
                    if (NajmniejszaOdleglosc == ObliczoneOdleglosci[i])
                    {
                        nrWierszaOsobnika = i;
                    }
                }
                nrWierszaPozycji = nrWierszaOsobnika;
                // znalezienie klasy dla pozycji dla której została obliczona najmniejsza odleglosc
                int KlasaOsobnika = Int32.Parse((String)dataGridView1[5, nrWierszaOsobnika].Value);

               
                if (KlasaOsobnika == 1)
                {
                    wynik = " Po analizie wartości wprowadzonych przez użytkownika\n System ekspertowy wspomagający wybór soczewek\n ustalił, iż pacjent powinnien nosić mocne soczewki  ";

                }
                else if (KlasaOsobnika == 2)
                {
                    wynik = " Po analizie wartości wprowadzonych przez użytkownika\n System ekspertowy wspomagający wybór soczewek\n ustalił, iż pacjent powinnien nosić słabe soczewki  ";

                }
                else if (KlasaOsobnika == 3)
                {
                    wynik = " Po analizie wartości wprowadzonych przez użytkownika\n System ekspertowy wspomagający wybór soczewek\n ustalił, że pacjentowi nie są potrzebne soczewki ";

                }


                Wynik wynik1 = new Wynik();
                wynik1.Show();
                this.Hide();
            }
        }

        private void labelIlośćDanych_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

