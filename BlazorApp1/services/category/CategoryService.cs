using System.Collections.Generic;
using BlazorApp1.models;
using System.Linq;
namespace BlazorApp1.services.category
{
    public class CategoryService : ICategoryService
    {
        List<Category> categories = new List<Category>
        {
            new Category(){Id=1,Name="clothes"},
            new Category(){Id=2,Name="furniture"},
            new Category(){Id=3,Name="computerAccessories"}
        };


        public List<Category> getAllCats()
        {
            return categories;
        }
        public Category getCatById(int id)
        {
            return categories.Where(cat=>cat.Id==id).FirstOrDefault();
        }
    }
}
