using ExecCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExecCliente.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Result (Cliente exec )
        {
            ViewBag.ObjetoCliente = exec;
            return View();
        }
    }
}