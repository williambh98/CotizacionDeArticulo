using CotizacionArticulo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionArticulo.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Articulos> articulosbl { get; set; }
        
        public Contexto() : base("ConStr")
        {

        }
    }
}
