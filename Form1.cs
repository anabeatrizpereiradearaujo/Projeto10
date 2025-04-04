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

namespace Projeto10
{
    public partial class Form1 : Form
    {
        Thread nt;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Beatriz" && textBox2.Text == "2424")
            {
                this.Close();
                 nt = new Thread(abrirPagina1);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();


            }
            else 
            {
                MessageBox.Show("Senha ou usuário Inválidos!");
            }
        }

        private void abrirPagina1()
        {
            Application.Run(new Pagina1());
        }

       
    }   


}
