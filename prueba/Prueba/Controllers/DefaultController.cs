using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ViewData["Prueba"] = "Prueba";
            return View();

        }

        public ActionResult Destinos()
        {
            
                // Crear una instancia de Destino
                Destino destino = new Destino();

                // Obtener la lista de destinos
                List<Destino> destinos = destino.ObtenerDestinos();

                // Pasar la lista a la vista
                return View(destinos);
            

        }

        
    }
   









}
