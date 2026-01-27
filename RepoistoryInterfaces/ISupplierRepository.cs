using GreenLife_Organic_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLife_Organic_Store.RepoistoryInterfaces
{
    public interface ISupplierRepository
    {
        List<Supplier> getAllSuppliers();
    }
}
