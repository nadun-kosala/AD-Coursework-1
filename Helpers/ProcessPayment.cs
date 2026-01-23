using GreenLife_Organic_Store.Models;
using GreenLife_Organic_Store.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.Helpers
{
    public class ProcessPayment
    {

        //Get cart items
        //Calculate total amount
        //Create order record
        //Create order details records
        //update stocks of products
        //Clear cart table
        //Redirect to orders page

        private readonly int _customerId;
        private readonly string _shippingAddress;

        private readonly CartRepository _cartRepo = new CartRepository();
        private readonly OrderRepository _orderRepo = new OrderRepository();
        private readonly OrderDetailRepository _orderDetailRepo = new OrderDetailRepository();
        private readonly ProductRepository _productRepo = new ProductRepository();

        public ProcessPayment(int customerId, string shippingAddress)
        {
            _customerId = customerId;
            _shippingAddress = shippingAddress;
        }

        public bool Process()
        {
            // 1️⃣ Get cart items
            var cartItems = _cartRepo.getCartProductsByCustomer(_customerId);

            if (cartItems.Count == 0)
                throw new Exception("Cart is empty");

            // 2️⃣ Calculate total
            decimal totalAmount = cartItems.Sum(i => i.subTotal);
            decimal discountAmount = 0m;
            decimal finalAmount = totalAmount - discountAmount;

            // 3️⃣ Create order
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

            // 4️⃣ Create order details
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

                // 5️⃣ Update product stock
                _productRepo.reduceStock(item.productId, item.cartQuantity);
            }

            // 6️⃣ Clear cart
            _cartRepo.clearCartByCustomer(_customerId);

            return true;
        }

        private string generateOrderCode()
        {
            return "ORD-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }
    }
}
