using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "Lista de productos";
        }

        [HttpGet("{id}")]
        public string GetProductById(int Id)
        {
            return "Un solo producto";
        }

    }
}