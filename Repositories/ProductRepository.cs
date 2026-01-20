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


        public List<Models.Product> getAllProducts()
        {
            var products = new List<Models.Product>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT p.product_id, p.product_name, p.price, p.stock_quantity, p.description, c.category_name FROM products p INNER JOIN categories c ON p.category_id = c.category_id";
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
                                    product.category = reader.GetString("category_name");
                                    product.price = reader.GetDecimal("price");
                                    product.stockQuantity = reader.GetInt32("stock_quantity");
                                    product.description = reader.GetString("description");
                                    products.Add(product);
                                }
                                ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred while retrieving products: " + ex.ToString());
            }
            return products;
        }

        public List<Models.Product> getAllProductsByName(string productName)
        {
            var products = new List<Models.Product>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT p.product_id, p.product_name, p.price, p.stock_quantity, p.description, c.category_name FROM products p INNER JOIN categories c ON p.category_id = c.category_id WHERE p.product_name LIKE @productName";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@productName", productName + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                {
                                    Product product = new Product();
                                    product.id = reader.GetInt32("product_id");
                                    product.productName = reader.GetString("product_name");
                                    product.category = reader.GetString("category_name");
                                    product.price = reader.GetDecimal("price");
                                    product.stockQuantity = reader.GetInt32("stock_quantity");
                                    product.description = reader.GetString("description");
                                    products.Add(product);
                                }
                                ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred while retrieving products: " + ex.ToString());
            }
            return products;
        }

        public Product? getProductById(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT p.product_id, p.product_name, p.price, p.stock_quantity, p.description, c.category_name, s.supplier_name FROM products p INNER JOIN categories c ON p.category_id = c.category_id INNER JOIN suppliers s ON p.supplier_id = s.supplier_id WHERE p.product_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Product product = new Product();
                                product.id = reader.GetInt32("product_id");
                                product.productName = reader.GetString("product_name");
                                product.category = reader.GetString("category_name");
                                product.price = reader.GetDecimal("price");
                                product.stockQuantity = reader.GetInt32("stock_quantity");
                                product.supplierName = reader.GetString("supplier_name");
                                product.description = reader.GetString("description");
                                return product;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving the product: " + ex.ToString());
            }


            return null;

        }


        public void createProduct(Product product)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO products (product_name, category_id, price, stock_quantity, supplier_id, description) VALUES (@productName, @categoryId, @price, @stockQuantity, @supplierId, @description)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@productName", product.productName);
                        cmd.Parameters.AddWithValue("@categoryId", product.categoryId);
                        cmd.Parameters.AddWithValue("@price", product.price);
                        cmd.Parameters.AddWithValue("@stockQuantity", product.stockQuantity);
                        cmd.Parameters.AddWithValue("@supplierId", product.supplierId);
                        cmd.Parameters.AddWithValue("@description", product.description);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the product: " + ex.ToString());

            }
        }


        public void updateProduct(Product product)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE products SET product_name = @productName, category_id = @categoryId, price = @price, stock_quantity = @stockQuantity, supplier_id = @supplierId, description = @description WHERE product_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@productName", product.productName);
                        cmd.Parameters.AddWithValue("@categoryId", product.categoryId);
                        cmd.Parameters.AddWithValue("@price", product.price);
                        cmd.Parameters.AddWithValue("@stockQuantity", product.stockQuantity);
                        cmd.Parameters.AddWithValue("@supplierId", product.supplierId);
                        cmd.Parameters.AddWithValue("@description", product.description);
                        cmd.Parameters.AddWithValue("@id", product.id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the product: " + ex.ToString());
            }
        }


        public void deleteProduct(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM products WHERE product_id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while deleting the product: " + ex.ToString());
            }
        }

    }
}
