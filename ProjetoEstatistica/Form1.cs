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

            //calculo media
            if (rdMedia.Checked)
            {
                double media = 0;
                media = (vetorDados[0] + vetorDados[1] + vetorDados[2] + vetorDados[3] + vetorDados[4] + vetorDados[5] + vetorDados[6]) / 7;
                txtMedia.Text = media.ToString();
            }

            //mediana
            if (rdMediana.Checked)
            {
                Array.Sort(vetorDados);

                double mediana = vetorDados[4];

                txtMediana.Text = mediana.ToString();
            }

            //moda
            if (rdModa.Checked)
            {
                int nVezes = 0;
                double moda = 0;
                int comparaV = 0;

                for (int i = 0; i < 7; i++)
                {
                    for (int x = i + 1; x < 7; x++)
                    {
                        if (vetorDados[i] == vetorDados[x])
                        {
                            ++nVezes;
                        }
                    }
                    if (nVezes > comparaV)
                    {
                        moda = vetorDados[i];
                        comparaV = nVezes;
                    }
                }
                txtModa.Text = moda.ToString();
            }

            //Desvio Padrão
            if (rdDesvPadrao.Checked)
            {
                double media = 0;
                double desvioPadrao1 = 0;
                double desvioPadrao2 = 0;
                double desvioPadrao = 0;

                media = (vetorDados[0] + vetorDados[1] + vetorDados[2] + vetorDados[3] + vetorDados[4] +
                   vetorDados[5] + vetorDados[6]) / 7;

                desvioPadrao1 = Math.Pow((vetorDados[0] - media), 2) + Math.Pow((vetorDados[1] - media), 2) + Math.Pow((vetorDados[2] - media), 2) + Math.Pow((vetorDados[3] - media), 2) +
                    Math.Pow((vetorDados[4] - media), 2) + Math.Pow((vetorDados[5] - media), 2) + Math.Pow((vetorDados[6] - media), 2);
                desvioPadrao2 = desvioPadrao1 / (7 - 1);
                desvioPadrao = Math.Sqrt(desvioPadrao2);
                txtDesvioPadrao.Text = desvioPadrao.ToString();

            }

            //1ºQuartil
            if (rdPriQuartil.Checked)
            {
                Array.Sort(vetorDados);
                double quartil1 = vetorDados[1];
                //double quartil1 = 0.25 * (7 - 1);

                txtPriQuartil.Text = quartil1.ToString();
            }

            //2ºQuartil
            if (rdSegQuartil.Checked)
            {
                Array.Sort(vetorDados);

                double quartil2 = 0;

                bool numImpar = (vetorDados.Length % 2 != 0);
                if (numImpar)
                {
                    int posicao = (vetorDados.Length + 1) / 2;
                    quartil2 = vetorDados[posicao - 1];
                }
                txtSegQuartil.Text = quartil2.ToString();
            }

            //3ºQuartil
            if (rdTerQuartil.Checked)
            {
                double quartil3 = 0;
                Array.Sort(vetorDados);
                quartil3 = vetorDados[4];
                //double quartil1 = 0.75 * (7 - 1);
                txtTerQuartil.Text = quartil3.ToString();
            }

            //Simetria
            if (rdSimetria.Checked)
            {
                double simetria = 0;
                double media = 0;
                double mediana = 0;
                double desvioPadrao1 = 0;
                double desvioPadrao2 = 0;
                double desvioPadrao = 0;

                //calculo media
                media = (vetorDados[0] + vetorDados[1] + vetorDados[2] + vetorDados[3] + vetorDados[4] +
                    vetorDados[5] + vetorDados[6]) / 7;

                //calculo mediana
                Array.Sort(vetorDados);
                bool numImpar = (vetorDados.Length % 2 != 0);
                if (numImpar)
                {
                    int posicao = (vetorDados.Length + 1) / 2;
                    mediana = vetorDados[posicao - 1];
                }

                //calculo desvio padrao
                media = (vetorDados[0] + vetorDados[1] + vetorDados[2] + vetorDados[3] + vetorDados[4] +
                  vetorDados[5] + vetorDados[6]) / 7;

                desvioPadrao1 = Math.Pow((vetorDados[0] - media), 2) + Math.Pow((vetorDados[1] - media), 2) + Math.Pow((vetorDados[2] - media), 2) + Math.Pow((vetorDados[3] - media), 2) +
                    Math.Pow((vetorDados[4] - media), 2) + Math.Pow((vetorDados[5] - media), 2) + Math.Pow((vetorDados[6] - media), 2);
                desvioPadrao2 = desvioPadrao1 / (7 - 1);
                desvioPadrao = Math.Sqrt(desvioPadrao2);

                simetria = 3 * (media - mediana) / desvioPadrao;

                txtSimetria.Text = simetria.ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = (" ");
            txtN2.Text = (" ");
            txtN3.Text = (" ");
            txtN4.Text = (" ");
            txtN5.Text = (" ");
            txtN6.Text = (" ");
            txtN7.Text = (" ");
            txtMedia.Text = (" ");
            txtMediana.Text = (" ");
            txtModa.Text = (" ");
            txtDesvioPadrao.Text = (" ");
            txtPriQuartil.Text = (" ");
            txtSegQuartil.Text = (" ");
            txtTerQuartil.Text = (" ");
            txtSimetria.Text = (" ");
            txtProbabilidade.Text = (" ");
        }

        private void btnProbabilidade_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numProbabilidade.Text);
            double[] vetorDados = new double[7];
            vetorDados[0] = Convert.ToDouble(txtN1.Text);
            vetorDados[1] = Convert.ToDouble(txtN2.Text);
            vetorDados[2] = Convert.ToDouble(txtN3.Text);
            vetorDados[3] = Convert.ToDouble(txtN4.Text);
            vetorDados[4] = Convert.ToDouble(txtN5.Text);
            vetorDados[5] = Convert.ToDouble(txtN6.Text);
            vetorDados[6] = Convert.ToDouble(txtN7.Text);

            //calculo media
            double media = 0;
            media = (vetorDados[0] + vetorDados[1] + vetorDados[2] + vetorDados[3] + vetorDados[4] +
                vetorDados[5] + vetorDados[6]) / 7;

            //calculo desvio padrao
            double desvioPadrao1 = 0;
            double desvioPadrao2 = 0;
            double desvioPadrao = 0;
            media = (vetorDados[0] + vetorDados[1] + vetorDados[2] + vetorDados[3] + vetorDados[4] +
                vetorDados[5] + vetorDados[6]) / 7;

            desvioPadrao1 = Math.Pow((vetorDados[0] - media), 2) + Math.Pow((vetorDados[1] - media), 2) + Math.Pow((vetorDados[2] - media), 2) +
                Math.Pow((vetorDados[3] - media), 2) + Math.Pow((vetorDados[4] - media), 2) + Math.Pow((vetorDados[5] - media), 2) + Math.Pow((vetorDados[6] - media), 2);

            desvioPadrao2 = desvioPadrao1 / (7 - 1);

            desvioPadrao = Math.Sqrt(desvioPadrao2);

            double num2 = Math.Pow(((num - media) / desvioPadrao), 2);

            double num3 = (-1 / 2) * num2;

            double numE = Math.Pow((1 + 1 / 7), 7);

            numE = Math.Pow(numE, num3);

            double prob = 1 / desvioPadrao * Math.Sqrt(2 * Math.PI) * numE;

            txtProbabilidade.Text = prob.ToString();

        }
    }
}
