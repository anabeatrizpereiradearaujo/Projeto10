using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto10.Geografia
{
    internal class materia
    {
        public string usuarios { get; set; }
        public string senha { get; set; }
        public string materia { get; set; }
        public int data { get; set; }
        public materia(string usauarios, string materia, int data)
        {
            this.usuarios = usuarios;
            this.materia = materia;
            this.data = data;
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine($"usuarios: {usuarios}");
            Console.WriteLine($"materia:  {materia}");
            Console.WriteLine($"data: {data} horas");
        }
    }
}
