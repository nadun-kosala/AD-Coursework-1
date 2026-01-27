using GreenLife_Organic_Store.Models;
using System.Collections.Generic;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface ICustomerRepository
    {
        List<Customer> getAllCustomers();
        List<Customer> getAllCustomersByNameOrEmail(string searchTerm);
        Customer? getCustomerById(int id);
        Customer? getCustomerByUserId(int id);
        void createCustomer(Customer customer);
        void updateCustomer(Customer customer);
        void deleteCustomer(int id);
        int getCurrentMonthCustomerCount();
        int getLastMonthCustomerCount();
    }
}