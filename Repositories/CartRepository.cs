using GreenLife_Organic_Store.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class CartRepository
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

    }
}
