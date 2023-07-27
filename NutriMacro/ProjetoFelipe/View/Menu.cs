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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<View.Paciente>();
        }

        private void btnIMCMenu_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<View.CalculoIMC>();
        }

        private void AbrirFormNoPainel<Forms>() where Forms : Form, new()
        {

            Forms formulario = new Forms();
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();


            }
        }
    }
}
