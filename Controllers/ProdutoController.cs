using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreMVC.Controllers
{

    [Route("api/product")]
    public class ProdutoController: Controller
    {
        // :int é uma constraint limitando para receber somente int, tem muito mais opções na documentação
        [HttpGet("{id:int}")]
        public int Get(int id)
        {
            return id;
        }

        // public string Get()
        // {
        //     HttpContext.Response.Headers.Add("Nome", "ShindiSan");
        //     HttpContext.Response.StatusCode = 404;
        //     return "";
        // }

        // public IActionResult Get()
        // {
        //     return Content("leandro","application/pdf");
        // }
        
        public IActionResult Get()
        {
            return File("images/banner1.svg","image/svg+xml");
        }
    }
}