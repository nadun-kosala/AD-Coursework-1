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
    public class SupplierRepository : ISupplierRepository
    {
        private readonly string connectionString = ConfigurationHelper.GetConnectionString("MyAppConnection");
        public List<Supplier> getAllSuppliers()
        {
            var suppliers = new List<Supplier>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT supplier_id, supplier_name, contact_person, email, phone, address FROM suppliers";
                using (MySqlCommand cmd = new MySqlCommand(query, con))

                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Supplier supplier = new Supplier();
                            supplier.supplierId = reader.GetInt32("supplier_id");
                            supplier.supplierName = reader.GetString("supplier_name");
                            supplier.contactPerson = reader.IsDBNull(reader.GetOrdinal("contact_person")) ? string.Empty : reader.GetString("contact_person");
                            supplier.email = reader.IsDBNull(reader.GetOrdinal("email")) ? string.Empty : reader.GetString("email");
                            supplier.phoneNumber = reader.IsDBNull(reader.GetOrdinal("phone")) ? string.Empty : reader.GetString("phone");
                            supplier.address = reader.IsDBNull(reader.GetOrdinal("address")) ? string.Empty : reader.GetString("address");
                            suppliers.Add(supplier);
                            ;
                        }
                    }
                }

            }

            return suppliers;
        }

        public void createSupplier(Supplier supplier)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"INSERT INTO suppliers (supplier_name, contact_person, email, phone, address) VALUES (@name, @contact, @email, @phone, @address)";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@name", supplier.supplierName);
                        cmd.Parameters.AddWithValue("@contact", supplier.contactPerson ?? string.Empty);
                        cmd.Parameters.AddWithValue("@email", supplier.email ?? string.Empty);
                        cmd.Parameters.AddWithValue("@phone", supplier.phoneNumber ?? string.Empty);
                        cmd.Parameters.AddWithValue("@address", supplier.address ?? string.Empty);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error creating supplier: " + ex.ToString());
                throw;
            }
        }
    }
}
