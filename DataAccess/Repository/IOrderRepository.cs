using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<OrderObject> GetListOrders();
        OrderObject GetOrderById(int orderId);
        IEnumerable<OrderObject> GetListOrderByMemID(int memberID);
        void AddOrder(OrderObject order);
        void UpdateOrder(OrderObject order);
        void DeleteOrder(int orderId);
    }
}
