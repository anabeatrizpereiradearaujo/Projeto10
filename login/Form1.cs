using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Projeto10.login;

namespace Projeto10
{
    public partial class Form1 : Form
    {
        Thread nt;
        private Form homeScrem;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Beatriz" && textBox2.Text == "2424")
            {
                this.Close();
                nt = new Thread(abrircadastroaluno);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();


            }
            else
            {
                MessageBox.Show("Senha ou usuário Inválidos!");
            }
        }

        private void abrircadastroaluno()
        {
            Application.Run(new cadastro_aluno());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncadastraraluno_Click(object sender, EventArgs e)
        {
            cadastro_aluno novoForm = new cadastro_aluno();
            novoForm.Show();
            this.Hide();
        }
    }
}




