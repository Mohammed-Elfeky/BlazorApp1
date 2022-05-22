using BlazorApp1.models;
using System.Collections.Generic;

namespace BlazorApp1.services.product
{
    public interface IProductService
    {
        List<Product> getAllProducts();
        Product getProductById(int id);
        void editProductById(int id, Product product);
    }
}