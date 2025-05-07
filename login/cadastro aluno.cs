using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto10.login
{
    public partial class cadastroaluno : Form
    {
        public cadastroaluno()
        {
            InitializeComponent();
        }

        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string nomeMae = txtNomeMae.Text;
            string cpf = txtCpf.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text; 
            DateTime dataNascimento = dtpDataNascimento.Value;

            Aluno aluno = new Aluno(nome, dataNascimento, nomeMae, cpf, email, senha);

            MessageBox.Show($"Aluno cadastrado com sucesso!\n\nNome: {aluno.Nome}\nData de Nascimento: {aluno.DataNascimento.ToShortDateString()}\nNome da Mãe: {aluno.NomeMae}\nCPF: {aluno.CPF}\nEmail: {aluno.Email}\nSenha: {aluno.Senha}", "Cadastro Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cadastroaluno_Load(object sender, EventArgs e)
        {

        }
    }

    public class Aluno
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; } 

        public Aluno(string nome, DateTime dataNascimento, string nomeMae, string cpf, string email, string senha)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            NomeMae = nomeMae;
            CPF = cpf;
            Email = email;
            Senha = senha;  
        }
    }
}
