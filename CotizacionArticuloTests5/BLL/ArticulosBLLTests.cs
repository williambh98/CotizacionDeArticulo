using Microsoft.VisualStudio.TestTools.UnitTesting;
using CotizacionArticulo.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CotizacionArticulo.Entidades;

namespace CotizacionArticulo.BLL.Tests
{
    [TestClass()]
    public class ArticulosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulos articulo = new Articulos()
            {
                ArticuloID = 10,
                Descripcion = "KLK WAWAWA",
                Precio = 0,
                Existencia = 1,
                CantidadCotizada = 1,
                FechaVencimiento = DateTime.Now
            };
            bool paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);

        }

        [TestMethod()]
        public void ModificarTest()
        {

            Articulos articulo = new Articulos()
            {
                ArticuloID = 10,
                Descripcion = "KLK WAWAWA",
                Precio = 0,
                Existencia = 1,
                CantidadCotizada = 1,
                FechaVencimiento = DateTime.Now
            };
            bool paso = ArticulosBLL.Modificar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {

            Articulos articulo = new Articulos()
            {
                ArticuloID = 10,
                Descripcion = "KLK WAWAWA",
                Precio = 0,
                Existencia = 1,
                CantidadCotizada = 1,
                FechaVencimiento = DateTime.Now
            };
            bool paso = ArticulosBLL.Guardar(articulo);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();

        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}