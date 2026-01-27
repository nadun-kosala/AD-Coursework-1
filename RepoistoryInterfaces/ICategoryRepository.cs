using GreenLife_Organic_Store.Models;
using System.Collections.Generic;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface ICategoryRepository
    {
        List<Category> getAllCategories();
    }
}