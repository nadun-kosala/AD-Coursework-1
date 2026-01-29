using GreenLife_Organic_Store.Models;
using System.Collections.Generic;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface ICartRepository
    {
        int getCartItemCountByCustomer(int customerId);
        List<Cart> getCartProductsByCustomer(int customerId);
        void createCartItem(Cart cart);
        void updateCartQuantity(int cartId, int quantity);
        void deleteCartItem(int cartId);
        void clearCartByCustomer(int customerId);
        bool isProductInCart(int productId, int customerId);
    }
}