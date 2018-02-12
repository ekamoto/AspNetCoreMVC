using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVC.Models;
using Microsoft.Extensions.Configuration;

namespace AspNetCoreMVC.Controllers
{
    public class HomeController : Controller
    {

        private IServico _IServico;
        private IConfiguration _IConfiguration;

        public  HomeController(IServico servico, IConfiguration configuration)
        {
            // Resolvendo problema, com injeção de dependência
            // O controller só conhece a interface e nem sabe do parâmetro passado no construtor
            _IServico = servico;
            _IConfiguration = configuration;
        }

        public IActionResult Index()
        {
            ViewData["URI"] = _IServico.buscarURI();
            ViewData["Environment"] = _IConfiguration.GetValue<string>("Environment");
            ViewData["Name"] = _IConfiguration.GetValue<string>("Name");

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
