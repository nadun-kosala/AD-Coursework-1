using GreenLife_Organic_Store.Models;
using System.Collections.Generic;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface IProductRepository
    {
        List<Product> getAllProducts();
        List<Product> getTopRatingProducts();
        List<Product> getAllProductsByName(string productName);
        List<Product> getFilteredProducts(int? categoryId, decimal? minPrice, decimal? maxPrice);
        Product? getProductById(int id);
        void createProduct(Product product);
        void updateProduct(Product product);
        void deleteProduct(int id);
        int getAllProductCount();
        int getUniqueProductsInStockCount();
        List<Product> getLowStockProducts();
        void reduceStock(int productId, int quantity);
    }
}