using Entities;

namespace Repositories
{
    public interface ICategoryRepositoty
    {
        Task<Category> AddCategory(Category category);
        Task<List<Category>> getAllCategories();
        Task<Category> getCategoryBtId(int id);
    }
}