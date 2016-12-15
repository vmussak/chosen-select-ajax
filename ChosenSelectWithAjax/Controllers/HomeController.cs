using ChosenSelectWithAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChosenSelectWithAjax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var clientes = ClienteFactory.BuscarClientes(string.Empty);

            var model = new Cliente
            {
                ComboClientes = new SelectList(clientes, "Id", "Nome")
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult GetClientes(string nome)
        {
            return Json(ClienteFactory.BuscarClientes(nome), JsonRequestBehavior.AllowGet);
        }
    }
}