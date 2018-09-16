using CotizacionArticulo.BLL;
using CotizacionArticulo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CotizacionArticulo.UI
{
    public partial class ConsultasArticulo : Form
    {
        public ConsultasArticulo()
        {
            InitializeComponent();
        }

        private void Burcarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Articulos>();
            if((CristeriotextBox.Text.Trim().Length > 0))
                {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = ArticulosBLL.GetList(p => true);
                        break;
                    case 1://ID
                        int id = Convert.ToInt32(CristeriotextBox.Text);
                        listado = ArticulosBLL.GetList(p => p.ArticuloID == id);
                        break;
                    case 2://Descripcion
                        listado = ArticulosBLL.GetList(p => p.Descripcion.Contains(CristeriotextBox.Text));
                            break;
                    case 3://Nombre
                        decimal precio = Convert.ToDecimal(CristeriotextBox.Text);
                        listado = ArticulosBLL.GetList(p => p.Precio == precio);
                        break;
                    case 4://Cantidad
                        int cant = Convert.ToInt32(CristeriotextBox.Text);
                        listado = ArticulosBLL.GetList(p => p.CantidadCotizada == cant);
                            break;
                    case 5://Existencia
                        int exi = Convert.ToInt32(CristeriotextBox.Text);
                        listado = ArticulosBLL.GetList(p => p.Existencia == exi);
                        break;
                }
                listado = listado.Where(c => c.FechaVencimiento.Date >= DesdedateTimePicker.Value.Date && c.FechaVencimiento.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = ArticulosBLL.GetList(p => true);
            }
            ConsultasdataGridView.DataSource = null;
            ConsultasdataGridView.DataSource = listado;
        }

    }
}
