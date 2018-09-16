using CotizacionArticulo.DAL;
using CotizacionArticulo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CotizacionArticulo.BLL
{
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulo)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if(contexto.articulosbl.Add(articulo) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Articulos articulos = new Articulos();
                contexto.articulosbl.Remove(articulos);
                if(contexto.SaveChanges()>0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();

            try
            {
                articulos = contexto.articulosbl.Find(id);
                contexto.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return articulos;
        }

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            List<Articulos> Articulos = new List<Articulos>();
            Contexto contexto = new Contexto();
            try
            {
                Articulos = contexto.articulosbl.Where(expression).ToList();
                contexto.Dispose();

            }catch(Exception)
            {
                throw;
            }
            return Articulos;
        }

    }
}
