using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ProductCategoryDAO: BaseDAL
    {
        //Using Singleton Pattern
        private static ProductCategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductCategoryDAO() { }
        public static ProductCategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductCategoryDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------------------------------------
        public IEnumerable<ProductCategoryObject> GetProductCategory()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select CategoryId, CategoryName from ProductCategory";
            var category = new List<ProductCategoryObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    category.Add(new ProductCategoryObject
                    {
                        CategoryId = dataReader.GetInt32(0),
                        CategoryName = dataReader.GetString(1),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return category;
        }

        public ProductCategoryObject GetCategoryById(int CategoryId)
        {
            IDataReader dataReader = null;
            ProductCategoryObject category = null;
            string SQLSelect = "Select CategoryId, CategoryName from ProductCategory where ProductId = @ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@CategoryId", 4, CategoryId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    category = new ProductCategoryObject
                    {
                        CategoryId = dataReader.GetInt32(0),
                        CategoryName = dataReader.GetString(1),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return category;
        }
    }
}
