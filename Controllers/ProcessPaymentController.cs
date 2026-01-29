using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.RepoistoryInterfaces;
using GreenLife_Organic_Store.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Controllers
{
    public class ProcessPaymentController
    {
        private readonly int _customerId;
        private readonly string _shippingAddress;

        private readonly ICartRepository _cartRepo = new CartRepository();
        private readonly IOrderRepository _orderRepo = new OrderRepository();
        private readonly IOrderDetailRepository _orderDetailRepo = new OrderDetailRepository();
        private readonly IProductRepository _productRepo = new ProductRepository();

        public ProcessPaymentController(int customerId, string shippingAddress)
        {
            _customerId = customerId;
            _shippingAddress = shippingAddress;
        }

        public bool process()
        {
            var cartItems = _cartRepo.getCartProductsByCustomer(_customerId);

            if (cartItems.Count == 0)
                throw new Exception("Cart is empty");

            decimal totalAmount = cartItems.Sum(i => i.subTotal);
            decimal discountAmount = 0m;
            decimal finalAmount = totalAmount - discountAmount;

            int orderId = _orderRepo.createOrder(new Order
            {
                customerId = _customerId,
                orderCode = generateOrderCode(),
                totalAmount = totalAmount,
                discountAmount = discountAmount,
                finalAmount = finalAmount,
                orderStatus = "Pending",
                shippingAddress = _shippingAddress
            });

            foreach (var item in cartItems)
            {
                _orderDetailRepo.createOrderDetail(new OrderDetail
                {
                    orderId = orderId,
                    productId = item.productId,
                    quantity = item.cartQuantity,
                    unitPrice = item.price,
                    subTotal = item.subTotal
                });

                _productRepo.reduceStock(item.productId, item.cartQuantity);
            }

            _cartRepo.clearCartByCustomer(_customerId);

            return true;
        }

        private string generateOrderCode()
        {
            return "ORD-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
