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
using Projeto10.Services;
using Projeto10.Model;

namespace Projeto10
{
    public partial class Form1 : Form
    {
        private RepositorioDados _repositorioDados;

        public Form1()
        {
            InitializeComponent();
            _repositorioDados = new RepositorioDados(new DatabaseService());
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

        private void Form1_Load(object sender, EventArgs e)
        {
           List<Materia> listMaterias =  _repositorioDados.getAllMaterias();

            comboBox1.DataSource = listMaterias;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";


        }
    }
}




