using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt16(txbNumero1.Text);
            int numero2 = Convert.ToInt16(txbNumero2.Text);
            //int resultado = numero1 * numero2;
            txbResultado.Text = Multiplicar(numero1,numero2).ToString();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt16(txbNumero1.Text);
            int numero2 = Convert.ToInt16(txbNumero2.Text);
            //int resultado = numero1 + numero2;
            txbResultado.Text = Somar(numero1, numero2).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt16(txbNumero1.Text);
            int numero2 = Convert.ToInt16(txbNumero2.Text);
            //int resultado = numero1 - numero2;
            txbResultado.Text = Subtrair(numero1,numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt16(txbNumero1.Text);
            int numero2 = Convert.ToInt16(txbNumero2.Text);
            //int resultado = numero1 / numero2;
            txbResultado.Text = Dividir(numero1,numero2).ToString();
        }

        int Somar(params int[] numeros)
        {
            int resultado = 0;
            foreach(int numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        int Multiplicar(int numero1,int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }
        int Dividir(int numero1,int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }
    }
}
