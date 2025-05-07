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

                this.Hide();
                Pagina1 pagina1 = new Pagina1();
                pagina1.Show();



            }
            else
            {
                MessageBox.Show("Senha ou usuário Inválidos!");
            }
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Primeiro acesso clicacado!");

            cadastroaluno novoForm = new cadastroaluno();
            novoForm.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}




