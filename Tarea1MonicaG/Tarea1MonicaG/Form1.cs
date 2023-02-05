using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1MonicaG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Resultadobutton1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            num1 = Convert.ToInt32(Numero1textBox1.Text);

                Calcular(num1);
                CNegativo(num1);
        }

        private int Calcular(int n1 )
        {
            int par = n1;
            int numeropar = 0;

            if ( par % 2 == 0)
            {
                MessageBox.Show("El numero es par");
           
            }
            else
            {
                MessageBox.Show("El numero es impar");
            }
            return numeropar;
        }

        private int CNegativo(int n1)
        {
            int negativo = n1;
            int numeroNegativo = 0;

            if (negativo <= -1)
            {
                MessageBox.Show("El numero es negativo");
            }
            else
            {
                MessageBox.Show("El numero es positivo");
            }
            return numeroNegativo;
        }

       
    }
}
