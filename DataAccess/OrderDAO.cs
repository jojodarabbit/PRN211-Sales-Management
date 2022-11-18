using BusinessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO : BaseDAL
    {
        //Using Singleton Pattern
        private static OrderDAO instance;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        //----------------------------------------
        public IEnumerable<OrderObject> GetListOrder()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight From \"Order\"";
            var orders = new List<OrderObject>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        MemberID = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return orders;
        }

        public OrderObject GetOrderByID(int orderID)
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight FROM \"Order\" where OrderId = @OrderId";
            OrderObject order = null;
            try
            {
                var param = dataProvider.CreateParameter("@OrderId", 4, orderID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    order = new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        MemberID = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return order;
        }

        public IEnumerable<OrderObject> GetListOrderByMemID(int memberId)
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select OrderId, MemberId, OrderDate, RequiredDate, ShippedDate, Freight FROM \"Order\" where MemberId=@MemberId";
            var orders = new List<OrderObject>();
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberId, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                while (dataReader.Read())
                {
                    orders.Add(new OrderObject
                    {
                        OrderID = dataReader.GetInt32(0),
                        MemberID = dataReader.GetInt32(1),
                        OrderDate = dataReader.GetDateTime(2),
                        RequiredDate = dataReader.GetDateTime(3),
                        ShippedDate = dataReader.GetDateTime(4),
                        Freight = dataReader.GetDecimal(5)
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
            return orders;
        }

        public void AddOrder(OrderObject order)
        {
            try
            {
                OrderObject orderObject = GetOrderByID(order.OrderID);
                if (orderObject == null)
                {
                    string SQLInsert = "Insert \"Order\" Values(@OrderId, @MemberId, @OrderDate, @RequiredDate, @ShippedDate, @Freight)";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@MemberId", 4, order.MemberID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@OrderDate", 8, order.OrderDate, DbType.DateTime));
                    parameter.Add(dataProvider.CreateParameter("@RequiredDate", 8, order.RequiredDate, DbType.DateTime));
                    parameter.Add(dataProvider.CreateParameter("@ShippedDate", 8, order.ShippedDate, DbType.DateTime));
                    parameter.Add(dataProvider.CreateParameter("@Freight", 4, order.Freight, DbType.Decimal));
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

        public void UpdateOrder(OrderObject order)
        {
            try
            {
                OrderObject orderObject = GetOrderByID(order.OrderID);
                if (orderObject != null)
                {
                    string SQLUpdate = "Update \"Order\" SET OrderDate = @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, Freight = @Freight where OrderId = @OrderId";
                    var parameter = new List<SqlParameter>();
                    parameter.Add(dataProvider.CreateParameter("@OrderId", 4, order.OrderID, DbType.Int32));
                    parameter.Add(dataProvider.CreateParameter("@OrderDate", 8, order.OrderDate, DbType.DateTime));
                    parameter.Add(dataProvider.CreateParameter("@RequiredDate", 8, order.RequiredDate, DbType.DateTime));
                    parameter.Add(dataProvider.CreateParameter("@ShippedDate", 8, order.ShippedDate, DbType.DateTime));
                    parameter.Add(dataProvider.CreateParameter("@Freight", 4, order.Freight, DbType.Decimal));
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

        public void DeleteOrder(int orderID)
        {
            try
            {
                OrderObject order = GetOrderByID(orderID);
                if (order != null)
                {
                    string SQLDelete = "DELETE \"Order\" WHERE OrderId = @OrderId";
                    var param = dataProvider.CreateParameter("@OrderId", 4, orderID, DbType.Int32);
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