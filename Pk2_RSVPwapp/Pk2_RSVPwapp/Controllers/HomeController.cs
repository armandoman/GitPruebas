using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pk2_RSVPwapp.Models;

namespace Pk2_RSVPwapp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ?
                "Buenos dias!!!!" : "BUenas tardes!!!";
            return View();
        }
        //Get :/Home/RsvpForm
        // Renderea el link de la forma del RSVP
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        //Responde a un Post: /Home/RsvpForm
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //verificando errores de validacion
            if (ModelState.IsValid)
            {
                //Todo: Enviar a un Post:/Home/RsvpForm
                return View("Agradecimientos", guestResponse);
            }
            else
            {
                //Hay problemas de validacion
                return View();
            }
        }
    }
}
    