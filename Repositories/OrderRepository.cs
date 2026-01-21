using GreenLife_Organic_Store.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class OrderRepository
    {
        private readonly string connectionString = "Server=localhost; Port=3306;Database=greenlife_organic_store;Uid=root;Pwd=root;";


        public List<Models.Order> getAllOrders()
        {
            var orders = new List<Models.Order>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    o.order_id,
                    o.order_code,
                    o.order_date,
                    o.total_amount,
                    o.discount_amount,
                    o.final_amount,
                    o.order_status,
                    o.shipping_address,
                    c.full_name
                FROM orders o
                INNER JOIN customers c ON o.customer_id = c.customer_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                {
                                    Order order = new Order();
                                    order.orderId = reader.GetInt32("order_id");
                                    order.orderCode = reader.GetString("order_code");
                                    order.orderDate = reader.GetDateTime("order_date");
                                    order.totalAmount = reader.GetDecimal("total_amount");
                                    order.discountAmount = reader.GetDecimal("discount_amount");
                                    order.finalAmount = reader.GetDecimal("final_amount");
                                    order.orderStatus = reader.GetString("order_status");
                                    order.shippingAddress = reader.GetString("shipping_address");
                                    order.customerName = reader.GetString("full_name");

                                    orders.Add(order);
                                }
                                ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving orders: " + ex.ToString());
            }
            return orders;
        }

        public List<Models.Order> getAllOrderByOrderCode(string orderCode)
        {
            var orders = new List<Models.Order>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    o.order_id,
                    o.order_code,
                    o.order_date,
                    o.total_amount,
                    o.discount_amount,
                    o.final_amount,
                    o.order_status,
                    o.shipping_address,
                    c.full_name
                FROM orders o
                INNER JOIN customers c ON o.customer_id = c.customer_id
                WHERE o.order_code LIKE @orderCode";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@orderCode", orderCode + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                {
                                    Order order = new Order();
                                    order.orderId = reader.GetInt32("order_id");
                                    order.orderCode = reader.GetString("order_code");
                                    order.orderDate = reader.GetDateTime("order_date");
                                    order.totalAmount = reader.GetDecimal("total_amount");
                                    order.discountAmount = reader.GetDecimal("discount_amount");
                                    order.finalAmount = reader.GetDecimal("final_amount");
                                    order.orderStatus = reader.GetString("order_status");
                                    order.shippingAddress = reader.GetString("shipping_address");
                                    order.customerName = reader.GetString("full_name");

                                    orders.Add(order);
                                }
                                ;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving orders: " + ex.ToString());
            }
            return orders;
        }

        public Order? getOrderById(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    order_id,
                    order_code,
                    order_date,
                    final_amount,
                    order_status
                FROM orders
                WHERE order_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Order order = new Order();
                                order.orderId = reader.GetInt32("order_id");
                                order.orderCode = reader.GetString("order_code");
                                order.orderDate = reader.GetDateTime("order_date");
                                order.finalAmount = reader.GetDecimal("final_amount");
                                order.orderStatus = reader.GetString("order_status");

                                return order;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving the order: " + ex.ToString());
            }

            return null;
        }

        public void updateOrderStatus(Order order)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "UPDATE orders SET order_status = @orderStatus WHERE order_id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@orderStatus", order.orderStatus);
                        cmd.Parameters.AddWithValue("@id", order.orderId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the order status: " + ex.ToString());
            }
        }

        public int getActiveOrdersCountThisMonth()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT COUNT(*)
                FROM orders
                WHERE order_status = 'Pending'
                  AND order_date >= DATE_FORMAT(CURDATE(), '%Y-%m-01')
                  AND order_date < DATE_ADD(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving active orders count: " + ex.ToString());
            }

            return 0;
        }

        public int getTotalOrdersCountThisMonth()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT COUNT(*)
                FROM orders
                WHERE order_status <> 'Cancelled'
                  AND order_date >= DATE_FORMAT(CURDATE(), '%Y-%m-01')
                  AND order_date < DATE_ADD(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving total orders count: " + ex.ToString());
            }

            return 0;
        }

        public decimal getThisMonthSalesAmount()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT IFNULL(SUM(final_amount), 0)
                FROM orders
                WHERE order_status <> 'Cancelled'
                  AND order_date >= DATE_FORMAT(CURDATE(), '%Y-%m-01')
                  AND order_date < DATE_ADD(DATE_FORMAT(CURDATE(), '%Y-%m-01'), INTERVAL 1 MONTH)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving this month sales amount: " + ex.ToString());
            }

            return 0;
        }

        public decimal getLastMonthSalesAmount()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT IFNULL(SUM(final_amount), 0)
                            FROM orders
                            WHERE order_status <> 'Cancelled'
                              AND order_date >= DATE_FORMAT(CURDATE() - INTERVAL 1 MONTH, '%Y-%m-01')
                              AND order_date < DATE_FORMAT(CURDATE(), '%Y-%m-01');
                            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        return Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving this month sales amount: " + ex.ToString());
            }

            return 0;
        }

    }
}
