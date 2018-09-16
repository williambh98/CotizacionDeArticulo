using CotizacionArticulo.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionArticulo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       
        private void registroCotizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroArticulo rg = new RegistroArticulo();
            rg.Show();
        }

        private void consultasArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasArticulo cs = new ConsultasArticulo();
            cs.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
