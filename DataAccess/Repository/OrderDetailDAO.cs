using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailDAO : BaseDAL
    {
        //Using Singleton Pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        //----------------------------------------------------------
        public IEnumerable<OrderDetailObject> GetListOrderDetails()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, ProductId, UnitPrice, Quantity, Discount From OrderDetail";
            var orderDetails = new List<OrderDetailObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orderDetails.Add(new OrderDetailObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        ProductID = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4),
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
            return orderDetails;
        }
        public OrderDetailObject GetOrderDetailById(int orderDetailId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, ProductId, UnitPrice, Quantity, Discount From OrderDetail where OrderId=@OrderId";
            OrderDetailObject orderDetail = null;
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, orderDetailId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    orderDetail = new OrderDetailObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        ProductID = dataReader.GetInt32(1),
                        UnitPrice = dataReader.GetDecimal(2),
                        Quantity = dataReader.GetInt32(3),
                        Discount = dataReader.GetDouble(4),
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
            return orderDetail;
        }
        public void AddOrderDetail(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject orderObject = GetOrderDetailById(orderDetail.OrderID);
                if (orderObject == null)
                {
                    string SQLInsert = "Insert OrderDetail Values(@OrderId, @ProductId, @UnitPrice, @Quantity, @Discount)";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@ProductId", 4, orderDetail.ProductID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@UnitPrice", 4, orderDetail.UnitPrice, DbType.Decimal));
                    parameter.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@Discount", 4, orderDetail.Discount, DbType.Double));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameter.ToArray());
                }
                else
                {
                    throw new Exception("The order is already exists.");
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
        public void UpdateOrderDetail(OrderDetailObject orderDetail)
        {
            try
            {
                OrderDetailObject orderObject = GetOrderDetailById(orderDetail.OrderID);
                if (orderObject != null)
                {
                    string SQLUpdate = "Update OrderDetail SET ProductId = @ProductId, UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount where OrderId = @OrderId";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@OrderId", 4, orderDetail.OrderID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@ProductId", 4, orderDetail.ProductID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@UnitPrice", 4, orderDetail.UnitPrice, DbType.Decimal));
                    parameter.Add(dataProvider.CreateParameter("@Quantity", 4, orderDetail.Quantity, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@Discount", 4, orderDetail.Discount, DbType.Double));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameter.ToArray());
                }
                else
                {
                    throw new Exception("This order doesn't eixsts.");
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
        public void DeleteOrderDetail(int orderDetailId)
        {
            try
            {
                OrderDetailObject order = GetOrderDetailById(orderDetailId);
                if (order != null)
                {
                    string SQLDelete = "DELETE OrderDetail WHERE OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, orderDetailId, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("This order doesn't exists.");
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
