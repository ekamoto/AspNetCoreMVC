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

    }
}