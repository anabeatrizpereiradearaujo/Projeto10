using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto10
{
    public partial class perguntas_e_respostas2 : Form
    {
        public perguntas_e_respostas2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novas questões adicionadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPergunta.Clear();
            txtAlternativaA.Clear();
            txtAlternativaB.Clear();
            txtAlternativaC.Clear();
            txtAlternativaD.Clear();
        }

        private void perguntas_e_respostas2_Load(object sender, EventArgs e)
        {

        }
    }
}
