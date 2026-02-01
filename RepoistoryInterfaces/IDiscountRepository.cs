using GreenLife_Organic_Store.Models;
using System.Collections.Generic;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface IDiscountRepository
    {
        Discount? getActiveDiscount();
        List<Discount> getAllDiscounts();
        void createDiscount(Discount discount);
        void incrementUsage(int discountId);
        void activateDiscount(int discountId);
        void deleteDiscount(int discountId);
    }
}
