using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EployeeQuiz.Models;

namespace EployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            //Creo el objeto
            // el modelo de datos

            PayrollDm nomina = new PayrollDm(
                @"C:\Users\armand\Documents\Visual Studio 2012\Projects\EployeeQuiz\EployeeQuiz\Models\emopleado.csv");


            //Busco el empleado id
            var empleado = nomina.GuetEmployeeById(emp.Id);

            return View("WorckerView", empleado);
        }
    }
}

       