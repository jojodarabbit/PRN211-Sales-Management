using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetailObject> GetListOrderDetails();
        OrderDetailObject GetOrderDetailById(int orderId);
        void AddOrderDetail(OrderDetailObject orderDetail);
        void UpdateOrderDetail(OrderDetailObject orderDetail);
        void DeleteOrderDetail(int orderId);
    }
}
