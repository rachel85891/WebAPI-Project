using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class ProductRepository : IProductRepository
    {
        webApiShop_216339176Context _context;
        public ProductRepository(webApiShop_216339176Context webApiShop_216339176Context)
        {
            _context = webApiShop_216339176Context;
        }

        public async Task<List<Product>> getAllProducts()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
