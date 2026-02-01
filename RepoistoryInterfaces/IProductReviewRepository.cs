using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface IProductReviewRepository
    {
        bool checkExistingReview(int productId, int customerId);
        void addReview(int productId, int customerId, int rating, string reviewText);
        void updateProductRatings(int productId);
    }
}
