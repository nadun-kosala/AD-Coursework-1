using GreenLife_Organic_Store.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class CustomerRepository
    {
        private readonly string connectionString = "Server=localhost; Port=3306;Database=greenlife_organic_store;Uid=root;Pwd=root;";
        public List<Models.Customer> getAllCustomers()
        {
            var customers = new List<Models.Customer>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM customers";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                {
                                    Customer customer = new Customer();
                                    customer.customerId = reader.GetInt32("customer_id");
                                    customer.fullName = reader.GetString("full_name");
                                    customer.email = reader.GetString("email");
                                    customer.phoneNumber = reader.GetString("phone");
                                    customer.address = reader.GetString("address");
                                    customer.registrationDate = reader.GetDateTime("registration_date");
                                    customers.Add(customer);
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
            return customers;
        }

        public List<Models.Customer> getAllCustomersByNameOrEmail(string searchTerm)
        {
            var customers = new List<Models.Customer>();
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM customers WHERE full_name LIKE @search OR email LIKE @search;";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                {
                                    Customer customer = new Customer();
                                    customer.customerId = reader.GetInt32("customer_id");
                                    customer.fullName = reader.GetString("full_name");
                                    customer.email = reader.GetString("email");
                                    customer.phoneNumber = reader.GetString("phone");
                                    customer.address = reader.GetString("address");
                                    customer.registrationDate = reader.GetDateTime("registration_date");
                                    customers.Add(customer);
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
            return customers;
        }


        public Customer? getCustomerById(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM customers WHERE customer_id = @customerId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerId", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Customer customer = new Customer();
                                customer.customerId = reader.GetInt32("customer_id");
                                customer.fullName = reader.GetString("full_name");
                                customer.email = reader.GetString("email");
                                customer.phoneNumber = reader.GetString("phone");
                                customer.address = reader.GetString("address");
                                customer.registrationDate = reader.GetDateTime("registration_date");
                                return customer;
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

        public void updateCustomer(Customer customer)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "UPDATE customers SET full_name = @customerName, email = @email, phone = @phoneNumber, address = @address WHERE customer_id = @customerId";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@customerName", customer.fullName);
                        cmd.Parameters.AddWithValue("@customerId", customer.customerId);
                        cmd.Parameters.AddWithValue("@email", customer.email);
                        cmd.Parameters.AddWithValue("@phoneNumber", customer.phoneNumber);
                        cmd.Parameters.AddWithValue("@address", customer.address);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while updating the product: " + ex.ToString());
            }
        }

        public void deleteCustomer(int id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM customers WHERE customer_id = @id";
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

        public int getCurrentMonthCustomerCount()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT COUNT(*) 
                FROM customers
                WHERE MONTH(registration_date) = MONTH(CURDATE())
                  AND YEAR(registration_date) = YEAR(CURDATE())";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving customer count: " + ex.ToString());
            }

            return 0;
        }

        public int getLastMonthCustomerCount()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT COUNT(*) 
                FROM customers
                WHERE registration_date >= DATE_FORMAT(CURDATE() - INTERVAL 1 MONTH, '%Y-%m-01')
                  AND registration_date < DATE_FORMAT(CURDATE(), '%Y-%m-01')";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving last month customer count: " + ex.ToString());
            }

            return 0;
        }

    }

}
