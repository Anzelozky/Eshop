using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Model;

namespace Core.Services.ProductsService
{
    public interface IProductService
    {
        public Task<List<Products>> GetAllProducts();

        public Task<Products> GetProductById(int Id);

        public Task<List<Products>> GetProductsBySellerId(int Id);
    }
}