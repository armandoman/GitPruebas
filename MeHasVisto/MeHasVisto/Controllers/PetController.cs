using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeHasVisto.Controllers
{
    public class PetController : Controller
    {
        //
        // GET: /Pet/

        public  ActionResult Display()
        {
            var name = (string)RouteData.Values["id"];
            //var model = PetManagement.GetByBame(name);
            //if (model == null)
                return RedirectToAction("NotFound");
            //return View(model);
        }

        public ActionResult NotFound()
        {
            return View();
        }
        public FilePathResult DowLoadPicture()
        {
            var name = (string)RouteData.Values["id"];
            var picture = "/Content/Uploads" + name + ".jpg";
            var contentType = "image/jpg";
            var fileName = name + ".jpg";
            return File(picture, contentType, fileName);
        }

    }
}
