using GreenLife_Organic_Store.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class ProductRepository
    {
        private readonly string connectionString = "Server=localhost; Port=3306;Database=greenlife_organic_store;Uid=root;Pwd=root;";


        public List<Models.Product> GetAllProducts()
        {
            var products = new List<Models.Product>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT product_id, product_name, price, stock_quantity, description FROM products";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                {
                                    Product product = new Product();
                                    product.id = reader.GetInt32("product_id");
                                    product.productName = reader.GetString("product_name");
                                    product.price = reader.GetDecimal("price");
                                    product.stockQuantity = reader.GetInt32("stock_quantity");
                                    product.description = reader.GetString("description");
                                    products.Add(product);
                                };
                            }
                        }
                    }
                }
            }
            catch ( Exception ex)
            {
                
               Console.WriteLine("An error occurred while retrieving products: " + ex.ToString());
            }
            return products;
        }
    }
}
