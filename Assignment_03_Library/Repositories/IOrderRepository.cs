using Assignment_03_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.Repositories
{
    public interface IOrderRepository
    {
        public int GetNextId();
        public Order GetOrderById(int id);
        public List<Order> GetOrderByMemberId(int id);
        public void AddOrder(Order order);
    }
}
