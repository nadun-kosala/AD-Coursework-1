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
    public class DiscountRepository : IDiscountRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");
        public Discount? getActiveDiscount()
        {

            Discount? discount = null;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT 
                    discount_id,
                    discount_code,
                    discount_percentage,
                    max_usage_count,
                    current_usage_count,
                    is_active
                FROM discounts
                WHERE 
                    is_active = TRUE
                    AND (max_usage_count IS NULL 
                         OR current_usage_count < max_usage_count)
                LIMIT 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            discount = new Discount
                            {
                                discountId = reader.GetInt32("discount_id"),
                                discountCode = reader.GetString("discount_code"),
                                percentage = reader.GetDecimal("discount_percentage"),
                                maxUsageCount = reader.IsDBNull(reader.GetOrdinal("max_usage_count")) ? 0 : reader.GetInt32("max_usage_count"),
                                currentUsageCount = reader.IsDBNull(reader.GetOrdinal("current_usage_count")) ? 0 : reader.GetInt32("current_usage_count"),
                                isActive = reader.GetBoolean("is_active")
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving active discount: " + ex.ToString());
            }

            return discount;
        }

        public List<Discount> getAllDiscounts()
        {
            var discounts = new List<Discount>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT discount_id, discount_code, discount_percentage, max_usage_count, current_usage_count, is_active FROM discounts ORDER BY discount_id DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                discounts.Add(new Discount
                                {
                                    discountId = reader.GetInt32("discount_id"),
                                    discountCode = reader.GetString("discount_code"),
                                    percentage = reader.GetDecimal("discount_percentage"),
                                    maxUsageCount = reader.IsDBNull(reader.GetOrdinal("max_usage_count")) ? 0 : reader.GetInt32("max_usage_count"),
                                    currentUsageCount = reader.IsDBNull(reader.GetOrdinal("current_usage_count")) ? 0 : reader.GetInt32("current_usage_count"),
                                    isActive = reader.GetBoolean("is_active")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving discounts: " + ex.ToString());
            }
            return discounts;
        }

        public void createDiscount(Discount discount)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO discounts (discount_code, discount_percentage, max_usage_count, current_usage_count, is_active) VALUES (@code, @percentage, @maxUsage, @currentUsage, @isActive)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@code", discount.discountCode);
                        cmd.Parameters.AddWithValue("@percentage", discount.percentage);
                        if (discount.maxUsageCount > 0)
                            cmd.Parameters.AddWithValue("@maxUsage", discount.maxUsageCount);
                        else
                            cmd.Parameters.AddWithValue("@maxUsage", DBNull.Value);

                        cmd.Parameters.AddWithValue("@currentUsage", discount.currentUsageCount);
                        cmd.Parameters.AddWithValue("@isActive", discount.isActive);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating discount: " + ex.ToString());
                throw;
            }
        }

        public void incrementUsage(int discountId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                                UPDATE discounts
                                SET current_usage_count = COALESCE(current_usage_count, 0) + 1,
                                    is_active = CASE
                                        WHEN max_usage_count IS NOT NULL AND COALESCE(current_usage_count, 0) + 1 >= max_usage_count THEN FALSE
                                        ELSE is_active
                                    END
                                WHERE discount_id = @discountId";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@discountId", discountId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error incrementing discount usage: " + ex.ToString());
            }
        }

        public void activateDiscount(int discountId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (var trx = con.BeginTransaction())
                    {
                        try
                        {
                            string deactivate = "UPDATE discounts SET is_active = FALSE";
                            using (var cmd = new MySqlCommand(deactivate, con, trx))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            string activate = "UPDATE discounts SET is_active = TRUE WHERE discount_id = @discountId";
                            using (var cmd2 = new MySqlCommand(activate, con, trx))
                            {
                                cmd2.Parameters.AddWithValue("@discountId", discountId);
                                int affected = cmd2.ExecuteNonQuery();
                                if (affected == 0)
                                {
                                    throw new InvalidOperationException("Discount not found.");
                                }
                            }

                            trx.Commit();
                        }
                        catch
                        {
                            try { trx.Rollback(); } catch { }
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error activating discount: " + ex.ToString());
                throw;
            }
        }

        public void deleteDiscount(int discountId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM discounts WHERE discount_id = @discountId";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@discountId", discountId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting discount: " + ex.ToString());
                throw;
            }
        }

    }
}
