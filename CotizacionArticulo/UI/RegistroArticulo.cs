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
    public partial class RegistroArticulo : Form
    {
        public RegistroArticulo()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            PreciotextBox.Text = Convert.ToString(0.0f);
            ExistenciatextBox.Text = Convert.ToString(0);
            CantidadnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            errorProvider.Clear();

        }

        //Boton nuevo limpia lo campos del registro
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Llenar Clase
        private Articulos LlenarClase()
        {
            Articulos articulos = new Articulos();
            articulos.ArticuloID = Convert.ToInt32(IDnumericUpDown.Value);
            articulos.Descripcion = DescripciontextBox.Text;
            articulos.Precio = Convert.ToSingle(PreciotextBox.Text);
            articulos.Existencia = Convert.ToInt32(ExistenciatextBox.Text);
            articulos.CantidadCotizada = Convert.ToInt32(CantidadnumericUpDown.Value);
            articulos.FechaVencimiento = FechadateTimePicker.Value;
            return articulos;

        }

        private void LlenarCampo(Articulos articulos)
        {
            
            CantidadnumericUpDown.Value = articulos.CantidadCotizada;
            DescripciontextBox.Text = articulos.Descripcion;
            PreciotextBox.Text = Convert.ToString(articulos.Precio);
            FechadateTimePicker.Value = articulos.FechaVencimiento;
            ExistenciatextBox.Text = Convert.ToString(articulos.Existencia);
            IDnumericUpDown.Value = articulos.ArticuloID;
        }

        private bool GuardarValidar()
        {
            errorProvider.Clear();
            bool paso = true;
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Ingrese Descripcion");
                paso = false;
            }
            if(CantidadnumericUpDown.Value <=0)
            {
                errorProvider.SetError(CantidadnumericUpDown, "Ingrese Cantidad");
                paso = false;
             }
            if (string.IsNullOrWhiteSpace(ExistenciatextBox.Text))
               {
                errorProvider.SetError(ExistenciatextBox, "Ingrese Existencia");
                paso = false;
               }
            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
            {
                errorProvider.SetError(PreciotextBox, "Ingrese Precio");
                paso = false;
            }
           /* if(FechadateTimePicker.Value <= DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker, "Ingrese Fecha");
                paso = false;
            }*/

            return paso;

        }

        private bool ExisteEnLaBAseDeDatos()
        {
            Articulos articulos = ArticulosBLL.Buscar((int)IDnumericUpDown.Value);
            return (articulos != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulos;

            bool paso = false;

            if(!GuardarValidar())
                return;
                
            
            articulos = LlenarClase();
            if (IDnumericUpDown.Value == 0)
                paso = ArticulosBLL.Guardar(articulos);
            else
            {
                if(!ExisteEnLaBAseDeDatos())
                {
                    MessageBox.Show("No se puede modificar algo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ArticulosBLL.Modificar(articulos);
            }

            if (paso)
                MessageBox.Show("Se Guardo Exitosamente");
            else
                MessageBox.Show("No se Guardo Exitosamente");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);

            if(!ExisteEnLaBAseDeDatos())
            {
                MessageBox.Show("No se encuentra");
                return;
            }
            if(ArticulosBLL.Eliminar(id))
            {
                MessageBox.Show("Se elimino Exitosamente", "Exitoso!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Articulos articulos = new Articulos();
            int.TryParse(IDnumericUpDown.Text, out id);
            articulos = ArticulosBLL.Buscar(id);
            if(articulos!=null)
            {
                LlenarCampo(articulos);
                MessageBox.Show("Articulo Encontrado");
            }
            else
            {
                MessageBox.Show("No se encontro");
            }
        }
    }
}
