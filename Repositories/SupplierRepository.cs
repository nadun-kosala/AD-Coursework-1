using GreenLife_Organic_Store.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Repositories
{
    public class SupplierRepository
    {
        private readonly string connectionString = "Server=localhost; Port=3306;Database=greenlife_organic_store;Uid=root;Pwd=root;";
        public List<Supplier> getAllSuppliers()
        {
            var suppliers = new List<Supplier>();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT supplier_id, supplier_name FROM suppliers";
                using (MySqlCommand cmd = new MySqlCommand(query, con))

                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Supplier supplier = new Supplier();
                            supplier.supplierId = reader.GetInt32("supplier_id");
                            supplier.supplierName = reader.GetString("supplier_name");
                            suppliers.Add(supplier);
                            ;
                        }
                    }
                }
               
            }

            return suppliers;
        }
    }
}
