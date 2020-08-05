using System.Collections.Generic;
using API.Model;
using API.Services.ProductsService;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Products>> GetProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Products> GetProductById(int Id)
        {
            var products = _productService.GetProductById(Id);
            
            if(products == null)
            {
                return Httpres
            }
            
            return Ok(products);
        }

    }
}