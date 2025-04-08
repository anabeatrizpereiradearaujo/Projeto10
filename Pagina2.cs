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
          
            this.Close();
            nt = new Thread(abrirPagina2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void abrirPagina2()
        {
            throw new NotImplementedException();
        }

        private void PAgina2_load(object sender, EventArgs e)
        {
            Application.Run(new Pagina2());
        }

        private void Pagina2_Load(object sender, EventArgs e)
        {
          Application.Run();
        }
    }
}
