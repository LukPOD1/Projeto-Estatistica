using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEstatistica
{
    public partial class frmEstatistica : Form
    {
        public frmEstatistica()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] vetorDados = new double[7];
            vetorDados[0] = Convert.ToDouble(txtN1.Text);
            vetorDados[1] = Convert.ToDouble(txtN2.Text);
            vetorDados[2] = Convert.ToDouble(txtN3.Text);
            vetorDados[3] = Convert.ToDouble(txtN4.Text);
            vetorDados[4] = Convert.ToDouble(txtN5.Text);
            vetorDados[5] = Convert.ToDouble(txtN6.Text);
            vetorDados[6] = Convert.ToDouble(txtN7.Text);
        }
    }
}
