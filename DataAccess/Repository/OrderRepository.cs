using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<OrderObject> GetListOrders() => OrderDAO.Instance.GetListOrder();
        public OrderObject GetOrderById(int orderId) => OrderDAO.Instance.GetOrderByID(orderId);
        public IEnumerable<OrderObject> GetListOrderByMemID(int memberID) => OrderDAO.Instance.GetListOrderByMemID(memberID);
        public void AddOrder(OrderObject order) => OrderDAO.Instance.AddOrder(order);
        public void UpdateOrder(OrderObject order) => OrderDAO.Instance.UpdateOrder(order);
        public void DeleteOrder(int orderId) => OrderDAO.Instance.DeleteOrder(orderId);
    }
}
