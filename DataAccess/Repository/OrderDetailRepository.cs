using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetailObject> GetListOrderDetails() => OrderDetailDAO.Instance.GetListOrderDetails();
        public OrderDetailObject GetOrderDetailById(int orderId) => OrderDetailDAO.Instance.GetOrderDetailById(orderId);
        public void AddOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.AddOrderDetail(orderDetail);
        public void UpdateOrderDetail(OrderDetailObject orderDetail) => OrderDetailDAO.Instance.UpdateOrderDetail(orderDetail);
        public void DeleteOrderDetail(int orderId) => OrderDetailDAO.Instance.DeleteOrderDetail(orderId);
    }
}
