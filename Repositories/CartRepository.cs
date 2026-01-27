using GreenLife_Organic_Store.Helpers;
using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");

        public int getCartItemCountByCustomer(int customerId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT COUNT(*)
                FROM carts
                WHERE customer_id = @customerId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting cart item count: " + ex.ToString());
                return 0;
            }
        }

        public List<Cart> getCartProductsByCustomer(int customerId)
        {
            List<Cart> items = new List<Cart>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    p.product_id,
                    p.product_name,
                    p.price,
                    p.stock_quantity,
                    c.quantity AS cart_quantity,
                    c.cart_id
                FROM carts c
                INNER JOIN products p ON p.product_id = c.product_id
                WHERE c.customer_id = @customerId;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Add(new Cart
                                {
                                    productId = reader.GetInt32("product_id"),
                                    productName = reader.GetString("product_name"),
                                    price = reader.GetDecimal("price"),
                                    stockQuantity = reader.GetInt32("stock_quantity"),
                                    cartQuantity = reader.GetInt32("cart_quantity"),
                                    cartId = reader.GetInt32("cart_id")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error fetching cart products: " + ex);
            }

            return items;
        }

        public void createCartItem(Cart cart)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                INSERT INTO carts (product_id, customer_id)
                VALUES (@productId, @customerId)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@productId", cart.productId);
                        cmd.Parameters.AddWithValue("@customerId", cart.customerId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating cart item: " + ex.ToString());
            }
        }


        public void updateCartQuantity(int cartId, int quantity)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                UPDATE carts
                SET quantity = @quantity
                WHERE cart_id = @cartId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@cartId", cartId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating cart quantity: " + ex.ToString());
            }
        }

        public void deleteCartItem(int cartId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"DELETE FROM carts WHERE cart_id = @cartId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@cartId", cartId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating cart quantity: " + ex.ToString());
            }
        }

        public void clearCartByCustomer(int customerId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM carts WHERE customer_id = @customerId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error clearing cart items: " + ex.ToString());
            }
           
        }

    }
}
