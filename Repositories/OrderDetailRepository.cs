using GreenLife_Organic_Store.Helpers;
using GreenLife_Organic_Store.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class OrderDetailRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");

        public void createOrderDetail(OrderDetail detail)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                            INSERT INTO order_details
                            (order_id, product_id, quantity, unit_price, subtotal)
                            VALUES
                            (@orderId, @productId, @quantity, @unitPrice, @subtotal)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", detail.orderId);
                    cmd.Parameters.AddWithValue("@productId", detail.productId);
                    cmd.Parameters.AddWithValue("@quantity", detail.quantity);
                    cmd.Parameters.AddWithValue("@unitPrice", detail.unitPrice);
                    cmd.Parameters.AddWithValue("@subtotal", detail.subTotal);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<OrderDetail> getOrderDetailsByOrderId(int orderId)
        {
            var items = new List<OrderDetail>();

            using (var con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = @"
            SELECT od.order_detail_id,
                   od.product_id,
                   p.product_name,
                   od.quantity,
                   od.unit_price,
                   od.subtotal
            FROM order_details od
            INNER JOIN products p ON p.product_id = od.product_id
            WHERE od.order_id = @orderId";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@orderId", orderId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(new OrderDetail
                            {
                                orderDetailId = reader.GetInt32("order_detail_id"),
                                productId = reader.GetInt32("product_id"),
                                productName = reader.GetString("product_name"),
                                quantity = reader.GetInt32("quantity"),
                                unitPrice = reader.GetDecimal("unit_price"),
                                subTotal = reader.GetDecimal("subtotal")
                            });
                        }
                    }
                }
            }

            return items;
        }


    }
}
