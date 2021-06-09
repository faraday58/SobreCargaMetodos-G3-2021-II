using System;
using System.Windows.Forms;

namespace SobreCargaMetodos_G3_2021_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private float Sumar(float sumando1, float sumando2)
        {
            return sumando1 + sumando2;
        }

        private float Sumar(float sumando1, float sumando2, float sumando3)
        {
            return sumando1 + sumando2+sumando3;
        }

        private void btnSumar1_Click(object sender, EventArgs e)
        {
            float suma = Sumar( float.Parse( txtbSumando1.Text) , float.Parse( txtbSumando2.Text));
            txtbSuma1.Text = suma.ToString();

        }

        private void btnSumar2_Click(object sender, EventArgs e)
        {
            float suma = Sumar(float.Parse(txtbSumando12.Text), float.Parse(txtbSumando22.Text),float.Parse(txtbSumando32.Text));
            txtbSuma2.Text = suma.ToString();

        }


    }
}
