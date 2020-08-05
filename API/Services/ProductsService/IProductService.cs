using System.Collections.Generic;
using System.Threading.Tasks;
using API.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Services.ProductsService
{
    public interface IProductService
    {
        public Task<List<Products>> GetAllProducts();

        public Task<Products> GetProductById(int Id);

        public Task<List<Products>> GetProductsBySellerId(int Id);
    }
}