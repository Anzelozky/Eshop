using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using API.Model;
using API.Responses;
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
        public async Task <IActionResult> GetProducts()
        {
            var products = await _productService.GetAllProducts();
            if (products == null)
            {
                return new HttpResponse<string>(HttpStatusCode.NotAcceptable,null,"No products found").Result;
            }
            return new HttpResponse<List<Products>>(HttpStatusCode.OK, products, "Success").Result;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int Id)
        {
            var product = await _productService.GetProductById(Id);
            
            if(product == null)
            {
                return new HttpResponse<string>(HttpStatusCode.NotAcceptable, null, "Product not found").Result;
            }
            
            return new HttpResponse<Products>(HttpStatusCode.OK, product, string.Concat("Product found for Id: ",Id)).Result;
        }

    }
}