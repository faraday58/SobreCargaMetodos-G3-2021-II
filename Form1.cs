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
            try
            {
                float suma = Sumar(float.Parse(txtbSumando1.Text), float.Parse(txtbSumando2.Text));
                txtbSuma1.Text = suma.ToString();
            }
            catch(FormatException error)
            {
                MessageBox.Show(error.Message + "\n Se ingresó un valor no válido" );
            }

            
            

        }

        private void btnSumar2_Click(object sender, EventArgs e)
        {
            try 
            {
                if(txtbSumando12.Text== "" ||  txtbSumando22.Text == ""  ||  txtbSumando32.Text == ""  )
                {
                    string error = "Debes ingresar un número en cada caja, no se puede quedar vacía ";
                    throw new ApplicationException(error);
                }
                float suma = Sumar(float.Parse(txtbSumando12.Text), float.Parse(txtbSumando22.Text), float.Parse(txtbSumando32.Text));
                txtbSuma2.Text = suma.ToString();
            }
            catch(ApplicationException error    ) 
            {
                MessageBox.Show(error.Message);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message + "\n Se ingresó un valor no válido");
            }

        }

        private void btnArreglo_Click(object sender, EventArgs e)
        {
            //int[] arreglo = new int[10];
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 23,52,12,15,0,9,7,1,20 };
            Array.Sort(arreglo);
            string StringAux = "";
            /*
            for (int i=0; i< arreglo.Length ; i++)
            {
               StringAux = StringAux +" " + arreglo[i].ToString();              

            }*/

            foreach (int num in arreglo     )
            {
                StringAux += " " + num.ToString();
            }


            txtbArreglo.Text = StringAux;


        }
    }
}
