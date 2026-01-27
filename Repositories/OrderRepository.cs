using GreenLife_Organic_Store.Helpers;
using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");


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

        public List<Models.Order> getAllOrderByCustomerId(int customerId)
        {
            var orders = new List<Models.Order>();
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
                    total_amount,
                    discount_amount,
                    final_amount,
                    order_status,
                    shipping_address
                FROM orders 
                WHERE customer_id = @customerId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);

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

                                    orders.Add(order);
                                }
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

        public int getActiveOrderCountByCustomerId(int customerId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT COUNT(*) 
                                    FROM orders 
                                    WHERE customer_id = @id 
                                      AND order_status NOT IN ('Delivered', 'Cancelled');";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", customerId);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving active order count: " + ex);
            }

            return 0;
        }


        public int createOrder(Order order)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                    INSERT INTO orders 
                    (order_code, customer_id, total_amount, discount_amount, final_amount, order_status, shipping_address)
                    VALUES
                    (@orderCode, @customerId, @totalAmount, @discountAmount, @finalAmount, @status, @address);
                    SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@orderCode", order.orderCode);
                        cmd.Parameters.AddWithValue("@customerId", order.customerId);
                        cmd.Parameters.AddWithValue("@totalAmount", order.totalAmount);
                        cmd.Parameters.AddWithValue("@discountAmount", order.discountAmount);
                        cmd.Parameters.AddWithValue("@finalAmount", order.finalAmount);
                        cmd.Parameters.AddWithValue("@status", order.orderStatus);
                        cmd.Parameters.AddWithValue("@address", order.shippingAddress);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

            }
            catch (Exception ex) {
                Console.WriteLine("An error occurred while creating the order: " + ex.ToString());
            }
            return 0;

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

        public List<Order> getSalesReport(DateTime startDate, DateTime endDate)
        {
            var list = new List<Order>();

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
        SELECT 
            o.order_code,
            DATE(o.order_date) AS order_date,
            c.full_name,
            o.total_amount,
            o.discount_amount,
            o.final_amount
        FROM orders o
        INNER JOIN customers c ON c.customer_id = o.customer_id
        WHERE o.order_status = 'Delivered'
        AND DATE(o.order_date) BETWEEN @startDate AND @endDate
        ORDER BY o.order_date ASC";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                    cmd.Parameters.AddWithValue("@endDate", endDate.Date);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Order
                            {
                                orderCode = reader.GetString("order_code"),
                                orderDate = reader.GetDateTime("order_date"),
                                customerName = reader.GetString("full_name"),
                                totalAmount = reader.GetDecimal("total_amount"),
                                discountAmount = reader.GetDecimal("discount_amount"),
                                finalAmount = reader.GetDecimal("final_amount")
                            });
                        }
                    }
                }
            }

            return list;
        }

        public List<Order> getOrdersByCustomerIdAndDateRange(int customerId, DateTime startDate, DateTime endDate)
        {
            var orders = new List<Order>();

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
                    total_amount,
                    discount_amount,
                    final_amount,
                    order_status,
                    shipping_address
                FROM orders
                WHERE customer_id = @customerId
                  AND DATE(order_date) BETWEEN @startDate AND @endDate
                ORDER BY order_date DESC;
            ";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@startDate", startDate.Date);
                        cmd.Parameters.AddWithValue("@endDate", endDate.Date);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                orders.Add(new Order
                                {
                                    orderId = reader.GetInt32("order_id"),
                                    orderCode = reader.GetString("order_code"),
                                    orderDate = reader.GetDateTime("order_date"),
                                    totalAmount = reader.GetDecimal("total_amount"),
                                    discountAmount = reader.GetDecimal("discount_amount"),
                                    finalAmount = reader.GetDecimal("final_amount"),
                                    orderStatus = reader.GetString("order_status"),
                                    shippingAddress = reader.GetString("shipping_address")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving customer order history: " + ex);
            }

            return orders;
        }

    }
}
