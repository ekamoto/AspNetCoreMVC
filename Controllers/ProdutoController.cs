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

        [HttpPost]
        public IActionResult Save(Produto produto)
        {
            if(produto.Id == 0 || string.IsNullOrEmpty(produto.Name) || produto.Price == 0)
            {
                ViewBag.MensagemErro = "Dados inválidos";
            }

            return View(produto);
        }
    }
}