using Assignment_03_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void Add(OrderDetail od) => OrderDetailsDAO.Instance.Add(od);

        public IEnumerable<OrderDetail> GetOrdersByOrderId(int id) => OrderDetailsDAO.Instance.GetOrdersByOrderId(id);
    }
}
