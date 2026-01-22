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
    public class UserRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");

        public User? getUser(string username)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT user_id, password, user_type, is_active
                                     FROM users 
                                     WHERE username = @username
                                     LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User();
                                user.userId = reader.GetInt32("user_id");
                                user.password = reader.GetString("password");
                                user.userType = reader.GetString("user_type");
                                user.isActive = reader.GetBoolean("is_active");
                                return user;
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

        public User? getUserById(int userId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT username, user_type, is_active
                                     FROM users 
                                     WHERE user_id = @userId
                                     LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                User user = new User();
                                user.username = reader.GetString("username");
                                user.userType = reader.GetString("user_type");
                                user.isActive = reader.GetBoolean("is_active");
                                return user;
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

        public int createUser(User user)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                INSERT INTO users 
                (username, password, user_type, is_active)
                VALUES 
                (@username, @password, @userType, @isActive);
                SELECT LAST_INSERT_ID();";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.Parameters.AddWithValue("@userType", user.userType);
                        cmd.Parameters.AddWithValue("@isActive", user.isActive);

                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating the user: " + ex.ToString());
            }
            return 0;
        }

    }
}
