using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionArticulo.Entidades
{
   public class Articulos
    {
        [Key]
        public int ArticuloID { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public int CantidadCotizada { get; set; }
        public DateTime FechaVencimiento { get; set; }
       
        public Articulos()
        {
            ArticuloID = 0;
            Descripcion = string.Empty;
            Precio = 0;
            Existencia = 0;
            CantidadCotizada = 0;
            FechaVencimiento = DateTime.Now;
        }

        public Articulos(int articuloid, string descripcion,decimal precio, int existencia, int cantidadcotizada, DateTime fechavencimiento )
        {
            ArticuloID = articuloid;
            this.Descripcion = descripcion;
            Precio = precio;
            Existencia = existencia;
            CantidadCotizada = cantidadcotizada;
            FechaVencimiento = fechavencimiento;

        }
        
    }
}
