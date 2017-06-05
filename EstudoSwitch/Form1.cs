using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSwitch
{
    public partial class FrmSwitch : Form
    {
        public FrmSwitch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int numeroDigitado = Convert.ToInt32(txtNumero.Text);
            // de 0 a 3 numero baixo
            // de 0 a 6 numero medio
            // de 6 pra cima numero alto

            switch (numeroDigitado)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    MessageBox.Show("Numero Baixo");
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                    MessageBox.Show("Numero Médio");
                    break;
                default:
                    MessageBox.Show("Numero Alto");
                    break;
            }
        }
    }
}
