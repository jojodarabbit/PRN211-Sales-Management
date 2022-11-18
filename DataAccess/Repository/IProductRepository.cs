using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<ProductObject> GetListProducts();
        ProductObject GetProductById(int productId);
        void AddProduct(ProductObject product);
        void UpdateProduct(ProductObject product);
        void DeleteProduct(int productId);
    }
}
