using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductObject> GetListProducts() => ProductDAO.Instance.GetListProduct();
        public ProductObject GetProductById(int productId) => ProductDAO.Instance.GetProductByID(productId);
        public void AddProduct(ProductObject product) => ProductDAO.Instance.AddProduct(product);
        public void UpdateProduct(ProductObject product) => ProductDAO.Instance.UpdateProduct(product);
        public void DeleteProduct(int productId) => ProductDAO.Instance.DeleteProduct(productId);
    }
}
