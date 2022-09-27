using Assignment_03_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order) => OrderDAO.Instance.AddOrder(order);

        public int GetNextId() => OrderDAO.Instance.GetNextId();

        public Order GetOrderById(int id) => OrderDAO.Instance.GetOrderById(id);

        public List<Order> GetOrderByMemberId(int id) => OrderDAO.Instance.GetOrderByMemberId(id);
    }
}
