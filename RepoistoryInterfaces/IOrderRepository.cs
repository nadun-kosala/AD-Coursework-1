using GreenLife_Organic_Store.Models;
using System.Collections.Generic;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        List<Order> getAllOrderByOrderCode(string orderCode);
        List<Order> getAllOrderByCustomerId(int customerId);
        Order? getOrderById(int id);
        int getActiveOrderCountByCustomerId(int customerId);
        int createOrder(Order order);
        void updateOrderStatus(Order order);
        int getActiveOrdersCountThisMonth();
        int getTotalOrdersCountThisMonth();
        decimal getThisMonthSalesAmount();
        decimal getLastMonthSalesAmount();
        List<Order> getSalesReport(DateTime startDate, DateTime endDate);
        List<Order> getOrdersByCustomerIdAndDateRange(int customerId, DateTime startDate, DateTime endDate);
    }
}