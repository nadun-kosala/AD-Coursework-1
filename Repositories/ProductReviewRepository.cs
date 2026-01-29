using GreenLife_Organic_Store.Helpers;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class ProductReviewRepository : IProductReviewRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");

        public bool checkExistingReview(int productId, int customerId)
        {
            try

            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM product_reviews WHERE product_id = @productId AND customer_id = @customerId";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        var count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking existing review: " + ex.ToString());
                return false;
            }
        }

        public void addReview(int productId, int customerId, int rating, string reviewText)
        {
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO product_reviews (product_id, customer_id, rating, review_text) VALUES (@productId, @customerId, @rating, @reviewText)";
                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@reviewText", reviewText ?? string.Empty);
                        cmd.ExecuteNonQuery();
                    }
                }

                updateProductRatings(productId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding product review: " + ex.ToString());
                throw;
            }
        }

        public void updateProductRatings(int productId)
        {
            try
            {
                using (var con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT AVG(rating) AS avgRating, COUNT(*) AS totalReviews
                        FROM product_reviews
                        WHERE product_id = @productId";

                    decimal avgRating = 0m;
                    int totalReviews = 0;

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@productId", productId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (!reader.IsDBNull(reader.GetOrdinal("avgRating")))
                                    avgRating = reader.GetDecimal("avgRating");
                                if (!reader.IsDBNull(reader.GetOrdinal("totalReviews")))
                                    totalReviews = reader.GetInt32("totalReviews");
                            }
                        }
                    }

                    string updateQuery = "UPDATE products SET average_rating = @avgRating, total_reviews = @totalReviews WHERE product_id = @productId";
                    using (var upd = new MySqlCommand(updateQuery, con))
                    {
                        upd.Parameters.AddWithValue("@avgRating", avgRating);
                        upd.Parameters.AddWithValue("@totalReviews", totalReviews);
                        upd.Parameters.AddWithValue("@productId", productId);
                        upd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating product ratings: " + ex.ToString());
            }
        }
    }
}
