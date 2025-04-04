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
    public partial class Pagina2 : Form
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! A alternativa correta é A";
        }

        private void Pagina2_Load(object sender, EventArgs e)
        {

        }
    }
}
