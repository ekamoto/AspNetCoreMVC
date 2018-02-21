using AspNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC.Controllers
{

    public class ProdutoController: Controller
    {
        [HttpGet]
        public IActionResult FormSave()
        {

            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult FormSave(Produto produto)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.MensagemErro = "Dados inválidos";
            }

            return View(produto);
        }
    }
}