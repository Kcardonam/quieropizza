using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {

            var producto1 = new ProductosModel();
            producto1.id = 1;
            producto1.Descripcion = "Pizza 6 quesos";

            var producto2 = new ProductosModel();
            producto2.id = 2;
            producto2.Descripcion = "Pizza 4 estaciones";

            var producto3 = new ProductosModel();
            producto3.id = 3;
            producto3.Descripcion = "Pizza 6 quesos";


            var listadeProductos = new List<ProductosModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);

            return View(listadeProductos);
        }
    }
}