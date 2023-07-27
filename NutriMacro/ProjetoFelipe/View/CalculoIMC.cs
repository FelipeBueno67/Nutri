using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFelipe.View
{
    public partial class CalculoIMC : Form
    {
        public CalculoIMC()
        {
            InitializeComponent();
        }


        int caseCalculo = 0;

        public void CalculoComida(float ResultCarb)
        {
            float valorTapRec = 0;
            float valorRecuperado = 0;
            float valorSucriRec = 0;

            if (cbxPao.Checked == true)
            {
                int valor = 4;
                cbxPao.Tag = valor;
                valorRecuperado = valor;

                if (cbxTapioca.Checked == true)
                {
                    int valorTap = 3;
                    cbxPao.Tag = valorTap;
                    valorTapRec = valorTap;
                }
                if (cbxSucri.Checked == true)
                {
                    int valorSucri = 2;
                    cbxPao.Tag = valorSucri;
                    valorSucriRec = valorSucri;
                }

                float resultadoValorComidas = valorRecuperado + valorTapRec + valorSucriRec;
                float comidaresult = resultadoValorComidas - ResultCarb;
                MessageBox.Show("Voce tem o valor de " + comidaresult);
            }
            else { }

        }

        public void Calculos(float result, int caseCalculo)
        {


            switch (caseCalculo)
            {
                case 1:
                    if (result >= 18.6 && result <= 24.9)
                    {
                        MessageBox.Show("Você está no peso ideal, parabéns");

                    }
                    else if (result >= 25 && result <= 29.9)
                    {
                        MessageBox.Show("Você está levementer a cima do peso, precisa perder um pouco de peso (NORMOCALORICA)");
                    }
                    else if (result >= 30)
                    {
                        MessageBox.Show("Você está obeso(a), precisa perder peso");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Confira seus dados novamente",
                            "Algo deu errado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        // for Warning  
                        //MessageBoxIcon.Error // for Error 
                        //MessageBoxIcon.Information  // for Information
                        //MessageBoxIcon.Question // for Question

                    }
                    break;
                case 2:

                    if (result >= 18.6 && result <= 24.9)
                    {


                        float resultCarbo = result * 4;
                        float resultProteina = result * 2;
                        CalculoComida(resultCarbo);
                        MessageBox.Show("Você precia comer " + resultCarbo + " de carbo e também " + resultProteina + " de proteína ");
                    }
                    else if (result >= 25 && result <= 29.9)
                    {
                        float resultCarbo = result * 4;
                        float resultProteina = result * Convert.ToSingle(2.5);
                        CalculoComida(resultCarbo);
                        MessageBox.Show("Você precia comer " + resultCarbo + " de carbo e também " + resultProteina + " de proteína ");
                    }
                    else if (result >= 30)
                    {
                        float resultCarbo = result * 3;
                        float resultProteina = result * Convert.ToSingle(2.5);
                        CalculoComida(resultCarbo);
                        MessageBox.Show("Você precia comer " + resultCarbo + " de carbo e também " + resultProteina + " de proteína ");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Confira seus dados novamente",
                            "Algo deu errado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        // for Warning  
                        //MessageBoxIcon.Error // for Error 
                        //MessageBoxIcon.Information  // for Information
                        //MessageBoxIcon.Question // for Question

                    }
                    break;
                default:
                    // código 3
                    break;
            }
        }

        public void btnResult_Click(object sender, EventArgs e)
        {
            float result = Convert.ToSingle(txtPeso.Text) / (Convert.ToSingle(txtSize.Text) * Convert.ToSingle(txtSize.Text));
            txtResult.Text = result.ToString();
            caseCalculo = 1;
            Calculos(result, caseCalculo);
        }

        private void btnMacro_Click(object sender, EventArgs e)
        {
            float result = Convert.ToSingle(txtPeso.Text) / (Convert.ToSingle(txtSize.Text) * Convert.ToSingle(txtSize.Text));
            caseCalculo = 2;
            Calculos(result, caseCalculo);

        }

        private void cbxPao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnMacro_Click_1(object sender, EventArgs e)
        {
            float result = Convert.ToSingle(txtPeso.Text) / (Convert.ToSingle(txtSize.Text) * Convert.ToSingle(txtSize.Text));
            caseCalculo = 2;
            Calculos(result, caseCalculo);
        }
    }
}
