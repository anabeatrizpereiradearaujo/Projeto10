using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto10
{
    public partial class Perguntas_e_Respostas : Form
    {
        public Perguntas_e_Respostas()
        {
            InitializeComponent();
        }

        private void Perguntas_e_Respostas_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Novas questões adicionadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPergunta.Clear();
            txtAlternativaA.Clear();
            txtAlternativaB.Clear();
            txtAlternativaC.Clear();
            txtAlternativaD.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = " Resposta correta!";
            radioButton1.ForeColor = Color.Green;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = " Resposta incorreta!"; 
            radioButton1.ForeColor = Color.Red;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = " Resposta incorreta!";
            radioButton1.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = " Resposta incorreta!";
            radioButton1.ForeColor = Color.Red;
        }
    }

}


