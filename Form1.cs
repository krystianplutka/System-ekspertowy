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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.labelAutorzy.Text = "Autorzy: \n Krystian Plutka \n Artur Komar \n Joachim Rosiński";
        }

        private void buttonRozpocznij_Click(object sender, EventArgs e)
        {
            Knn knn = new Knn();

            knn.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
