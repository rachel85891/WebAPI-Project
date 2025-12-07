using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepositoty : ICategoryRepositoty
    {
        webApiShop_216339176Context _context;
        public CategoryRepositoty(webApiShop_216339176Context webApiShop_216339176Context)
        {
            _context = webApiShop_216339176Context;
        }
        public async Task<List<Category>> getAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> getCategoryBtId(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<Category> AddCategory(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
