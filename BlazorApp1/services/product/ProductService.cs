using System.Collections.Generic;
using BlazorApp1.models;
using System.Linq;
namespace BlazorApp1.services.product
{
    public class ProductService : IProductService
    {
        List<Product> products = new List<Product>
        {
            new Product(){Id=1,Name="shirt",price=20,info="good shirt",image="1.jpg",cat_Id=1},
            new Product(){Id=2,Name="jacket",price=60,info="good jacket",image="2.jpg",cat_Id=1},
            new Product(){Id=3,Name="sofa",price=200,info="good sofa",image="3.jpg",cat_Id=2},
            new Product(){Id=4,Name="chair",price=300,info="good chair",image="4.jpg",cat_Id=2},
            new Product(){Id=5,Name="mouse",price=10,info="good mouse",image="5.jpg",cat_Id=3},
            new Product(){Id=6,Name="keyboard",price=15,info="good keyboard",image="6.jpg",cat_Id=3},
        };


        public List<Product> getAllProducts()
        {
            return products;
        }
        public Product getProductById(int id)
        {
            return products.Where(p => p.Id == id).FirstOrDefault();
        }
        public void editProductById(int id,Product product)
        {
            Product oldProduct=products.Where(product=>product.Id==id).FirstOrDefault();
            oldProduct = product;
        }
    }
}
