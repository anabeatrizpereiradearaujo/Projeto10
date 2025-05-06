using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto10.login
{
    internal class usuarios
    {
        public string nome { get; set; }
        public string senha { get; set; }
        public string materia { get; set; }
        public int data { get; set; }
        public usuarios(string nome, string senha)
        {
            this.nome = nome;
            this.senha = senha;
        }
        public bool ValidarSenha(string senha)
        {
            return senha == senha;
        }
    }
}
