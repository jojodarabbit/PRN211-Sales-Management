using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductCategoryRepository : IProductCategory
    {
        public IEnumerable<ProductCategoryObject> GetCategories() => ProductCategoryDAO.Instance.GetProductCategory();
        
        public ProductCategoryObject GetCategoryById(int CategoryId)=> ProductCategoryDAO.Instance.GetCategoryById(CategoryId);
        
    }
}
