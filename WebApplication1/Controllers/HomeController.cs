using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Models.ViewModels.Class1 model)
        {
            if (model == null)
                model = new Models.ViewModels.Class1();
            return View(model);
        }

        [HttpPost]
        public ActionResult Save(Models.ViewModels.Class1 model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", model);
            }
            return RedirectToAction("Success");
        }

        public ActionResult Success()
        {
            return View();
        }
       
    }
}