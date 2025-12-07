using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepositoty _repository;

        public CategoryService(ICategoryRepositoty repository)
        {
            _repository = repository;
        }

        public async Task<List<Category>> getAllCategories()
        {
            return await _repository.getAllCategories();
        }
    }
}
