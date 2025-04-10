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

namespace Projeto10
{
    public partial class Pagina1 : Form
    {
        Thread nt;
        public Pagina1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! A alternativa correta é B";
            label1.ForeColor = Color.Red;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = " Resposta Correta!";
            label1.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! A alternativa correta é B";
            label1.ForeColor = Color.Red;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = " Resposta incorreta! A alternativa correta é B";
            label1.ForeColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
         
         
}

        

       

      

