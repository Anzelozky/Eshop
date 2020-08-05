using System.Threading.Tasks;
using System.Linq;
using API.DB;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Services.ProductsService
{
    public class ProductService : IProductService
    {
        private readonly StoreContext _context;
        public ProductService(StoreContext context)
        {
            _context = context;
        }

        public async Task<List<Products>> GetAllProducts()
        {
            var result = await _context.products.ToListAsync();
            return result;
        }

        public async Task<Products> GetProductById(int Id)
        {
            var result = await _context.products.Where(x => x.Id == Id).FirstOrDefaultAsync().ConfigureAwait(false);
            return result;
        }

        public async Task<List<Products>> GetProductsBySellerId(int Id)
        {
            var result = await _context.products.Where(x => x.Seller.Id == Id).ToListAsync();
            return result;
        }
    }
}