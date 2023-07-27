using MySql.Data.MySqlClient;
using ProjetoFelipe.Model;
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
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private PacienteModel pacientesModel;

        int caseCalculo = 0;

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
                        MessageBox.Show("Você precia comer " + resultCarbo + " de carbo e também " + resultProteina + " de proteína ");
                    }
                    else if (result >= 25 && result <= 29.9)
                    {
                        float resultCarbo = result * 4;
                        float resultProteina = result * Convert.ToSingle(2.5);
                        MessageBox.Show("Você precia comer " + resultCarbo + " de carbo e também " + resultProteina + " de proteína ");
                    }
                    else if (result >= 30)
                    {
                        float resultCarbo = result * 3;
                        float resultProteina = result * Convert.ToSingle(2.5);
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
            //txtResult.Text = result.ToString();
            caseCalculo = 1;
            Calculos(result, caseCalculo);
        }

        private void btnMacro_Click(object sender, EventArgs e)
        {
            float result = Convert.ToSingle(txtPeso.Text) / (Convert.ToSingle(txtSize.Text) * Convert.ToSingle(txtSize.Text));
            caseCalculo = 2;
            Calculos(result, caseCalculo);

        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            this.pacientesModel = new PacienteModel();
            MySqlDataReader temp = this.pacientesModel.ListarPacientes();
            DataTable dt = new DataTable();
            dt.Load(temp);
            dgvPaciente.DataSource = dt;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string campo = cboFiltro.Text;
            string fitro = txtFiltro.Text;
            if (campo == "id")
            {
                campo = "idPacientes";
            }
            MySqlDataReader temp = this.pacientesModel.ListarPacientes(campo, fitro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            dgvPaciente.DataSource = dt;
        }

        private void dgvPaciente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow linha = dgvPaciente.Rows[e.RowIndex];
            txtName.Text = linha.Cells[0].Value.ToString();
            txtPeso.Text = linha.Cells[1].Value.ToString();
            txtAge.Text = linha.Cells[2].Value.ToString();
            txtSize.Text = linha.Cells[3].Value.ToString();
        }
    }
}
