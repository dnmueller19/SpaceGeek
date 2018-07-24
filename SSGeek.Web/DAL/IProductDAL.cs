using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SSGeek.Web.Models;

namespace SSGeek.Web.DAL
{
    public interface IProductDAL
    {
		Product GetProduct(int id);
		IList<Product> GetProducts();
    }
}
