using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projeto10
{
    public partial class Pagina2 : Form
    {
        Thread nt;
        public Pagina2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! A alternativa correta é A";
            label1.ForeColor = Color.Red;
        }

        private void Pagina2_Load(object sender, EventArgs e)
        {

            Application.Run(new Pagina2());
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void abrirPagina2()
        {
            Application.Run(new Pagina2());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Resposta correta! ";
            label1.ForeColor = Color.Green;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! ";
            label1.ForeColor = Color.Red;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! ";
            label1.ForeColor = Color.Red;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! ";
            label1.ForeColor = Color.Red;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            perguntas_e_respostas2 proximaTela = new perguntas_e_respostas2();
            proximaTela.Show();
            this.Hide();
        }
    }
}




