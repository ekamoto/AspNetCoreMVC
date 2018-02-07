using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVC.Models;

namespace AspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {

        private IServico _IServico;

        public  HomeController()
        {
            // Problema de acoplamento
            // Responsabilidade demais para o controller, e controller tem informação desnecessária
            _IServico = new Servico("https://leandroekamoto.wordpress.com/curriculum/");
        }

        public IActionResult Index()
        {
            ViewData["URI"] = _IServico.buscarURI();

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
