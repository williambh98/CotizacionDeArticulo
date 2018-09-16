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
            PrecionumericUpDown.Value = 0;
            ExistencianumericUpDown.Value = 0;
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
            articulos.Precio = Convert.ToDecimal(PrecionumericUpDown.Value);
            articulos.Existencia = Convert.ToInt32(ExistencianumericUpDown.Value);
            articulos.CantidadCotizada = Convert.ToInt32(CantidadnumericUpDown.Value);
            articulos.FechaVencimiento = FechadateTimePicker.Value;
            return articulos;

        }
        /*
        private void LlenarCampo(Articulos articulos)
        {
            
            CantidadnumericUpDown.Value = articulos.CantidadCotizada;
            DescripciontextBox.Text = articulos.Descripcion;
            PrecionumericUpDown.Value = articulos.Precio;
            FechadateTimePicker.Value = articulos.FechaVencimiento;
            ExistencianumericUpDown.Value =articulos.Existencia;
            IDnumericUpDown.Value = articulos.ArticuloID;
        }
        */

        private bool GuardarValidar()
        {
            errorProvider.Clear();
            bool paso = true;
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Ingrese Descripcion");
                paso = false;
            }
            if (CantidadnumericUpDown.Value <= 0)
            {
                errorProvider.SetError(CantidadnumericUpDown, "Ingrese Cantidad");
                paso = false;
            }
            if (ExistencianumericUpDown.Value <= 0)
            {
                errorProvider.SetError(ExistencianumericUpDown, "Ingrese Existencia");
                paso = false;
            }
            if (PrecionumericUpDown.Value <= 0)
            {
                errorProvider.SetError(PrecionumericUpDown, "Ingrese Precio");
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

            if (!GuardarValidar())
                return;


            articulos = LlenarClase();
            if (IDnumericUpDown.Value == 0)
                paso = ArticulosBLL.Guardar(articulos);
            else
            {
                if (!ExisteEnLaBAseDeDatos())
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
    

        
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id = Convert.ToInt32(IDnumericUpDown.Value);
            Articulos articulo = BLL.ArticulosBLL.Buscar(id);

            if (GuardarValidar())
            {
                MessageBox.Show("Llene Casilla");
            }
            else
            {
                if (articulo != null)
                {
                   IDnumericUpDown.Value = articulo.ArticuloID;
                    FechadateTimePicker.Value = articulo.FechaVencimiento;
                    DescripciontextBox.Text = articulo.Descripcion;
                    PrecionumericUpDown.Value = articulo.Precio;
                    ExistencianumericUpDown.Value = articulo.Existencia;
                    CantidadnumericUpDown.Value = articulo.CantidadCotizada;
                    errorProvider.Clear();
                }
                else
                {
                    MessageBox.Show("No se Encontro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider.Clear();
                }
            }
        
        /*
        int id;
        Articulos articulos = new Articulos();
        int.TryParse(IDnumericUpDown.Text, out id);
        articulos = ArticulosBLL.Buscar(id);

        if (articulos != null)
        {
            LlenarCampo(articulos);
            MessageBox.Show("Articulo Encontrado");
        }
        else
        {
            MessageBox.Show("No se encontro");
        }
        */
    }
        
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
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

        private void RegistroArticulo_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
