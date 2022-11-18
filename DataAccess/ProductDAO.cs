using BusinessObject;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ProductDAO : BaseDAL
    {
        //Using Singleton Pattern
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        //---------------------------------------------------------------
        public IEnumerable<ProductObject> GetListProduct()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitsInStock from Product";
            var products = new List<ProductObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    products.Add(new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5),
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
            return products;
        }

        public ProductObject GetProductByID(int productID)
        {
            IDataReader dataReader = null;
            ProductObject product = null;
            string SQLSelect = "Select ProductId, CategoryId, ProductName, Weight, UnitPrice, UnitsInStock from Product where ProductId = @ProductId";
            try
            {
                var param = dataProvider.CreateParameter("@ProductId", 4, productID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    product = new ProductObject
                    {
                        ProductID = dataReader.GetInt32(0),
                        CategoryID = dataReader.GetInt32(1),
                        ProductName = dataReader.GetString(2),
                        Weight = dataReader.GetString(3),
                        UnitPrice = dataReader.GetDecimal(4),
                        UnitsInStock = dataReader.GetInt32(5),
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
            return product;
        }
        public void AddProduct(ProductObject product)
        {
            try
            {
                ProductObject productObject = GetProductByID(product.ProductID);
                if (productObject == null)
                {
                    string SQLInsert = "Insert Product Values(@ProductId, @CategoryId, @ProductName, @Weight, @UnitPrice, @UnitsInStock)";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@UnitPrice", 4, product.UnitPrice, DbType.Decimal));
                    parameter.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameter.ToArray());
                }
                else
                {
                    throw new Exception("This product is already exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void UpdateProduct(ProductObject product)
        {
            try
            {
                ProductObject productObject = GetProductByID(product.ProductID);
                if (productObject != null)
                {
                    string SQLUpdate = "Update Product Set CategoryId = @CategoryId, ProductName = @ProductName, Weight = @Weight, UnitPrice = @UnitPrice, UnitsInStock = @UnitsInStock Where ProductId = @ProductId";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@ProductId", 4, product.ProductID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@CategoryId", 4, product.CategoryID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@ProductName", 50, product.ProductName, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@Weight", 50, product.Weight, DbType.String));
                    parameter.Add(dataProvider.CreateParameter("@UnitPrice", 4, product.UnitPrice, DbType.Decimal));
                    parameter.Add(dataProvider.CreateParameter("@UnitsInStock", 4, product.UnitsInStock, DbType.Int32));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameter.ToArray());
                }
                else
                {
                    throw new Exception("This product doesn't exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void DeleteProduct(int productId)
        {
            try
            {
                ProductObject product = GetProductByID(productId);
                if (product != null)
                {
                    string SQLDelete = "Delete Product where ProductId = @ProductId";
                    var parameter = dataProvider.CreateParameter("@ProductId", 4, productId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameter);
                }
                else
                {
                    throw new Exception("This product doesn't exists.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
