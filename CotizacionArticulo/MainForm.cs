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
            RegistroArticulo rg = new RegistroArticulo();
            rg.Show();
            //InitializeComponent();
        }
    }
}
