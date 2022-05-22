using BlazorApp1.models;
using System.Collections.Generic;

namespace BlazorApp1.services.category
{
    public interface ICategoryService
    {
        List<Category> getAllCats();
        Category getCatById(int id);
    }
}