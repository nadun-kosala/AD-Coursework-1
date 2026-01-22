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
    public class CategoryRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");

        public List<Category> getAllCategories()
        {
            var categories = new List<Category>();

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT category_id, category_name FROM categories";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                categories.Add(new Category
                                {
                                    categoryId = reader.GetInt32("category_id"),
                                    categoryName = reader.GetString("category_name")
                                });
                            }
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred while retrieving categories: " + ex.ToString());
            }

            return categories;
        }
    }
}
