using GreenLife_Organic_Store.Models;
using System.Collections.Generic;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface IOrderDetailRepository
    {
        void createOrderDetail(OrderDetail detail);
        List<OrderDetail> getOrderDetailsByOrderId(int orderId);
    }
}