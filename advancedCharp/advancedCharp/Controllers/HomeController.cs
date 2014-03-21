using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using advancedCharp.Models;

namespace advancedCharp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            return View();
        }
        public ViewResult AutoProperty()
        {
            //crea un nueva objeto
            //de la clase producto
            Product myProduct = new Product
            {
                //Establece el valor de la propiedad
                ProductID = 12,
                Name = "kayak",
                Descripction = "Kiosteca Blue",
                category = "SPORTS",
                price = 12.5f
            };
            string salida =
                String.Format("{0}-{1}-{2}-{3}-{4:0}",
                myProduct.ProductID,
                myProduct.Name,
                myProduct.Descripction,
                myProduct.category,
                myProduct.price);
            //genera la vista
            return View("Results",
                (object)salida);

            //obtiene la propiedad
            string productName = myProduct.Name;

            //Genera la vista
            return View("Results",
                (object)String.Format("Nombre del producto: {0}", productName));
        }
        public ViewResult CreateCollection()
        {

            //arreglos de String
            string[] stringArray = { "manzana", "naranja", "lima" };

            //lista
            List<int> intList = new List<int> { 10, 20, 30, 40 };

            //diccioraios
            Dictionary<string, int> myDict = new Dictionary<string, int>
            {
                {"Manzana",10 },
                {"Naranja",20 },
                {"Lima",30 }
            };
            return View("Results", (object)myDict["Lima"].ToString());
        }
        public ViewResult useExtension()
        {
            // Creacion e inicializacion de 
            // Shipping cart (carrito de compras)
            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product> 
                {
                new Product{Name = "kayac", price = 3250.0f},
                new Product{Name = "Lentes", price = 1500.0f},
                new Product{Name = "Balon Football", price = 50.0f},
                new Product{Name = "Disco volador", price = 130.0f},
            }
            };

            // Obiteniendo el total de la compra
            double total = cart.TotalPrices();

            //Renderenado vista
            return View("Results",
            (object)String.Format("Total: {0:c}", total));
        }
    }
}
