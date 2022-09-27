using Assignment_03_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.Repositories
{
    public interface IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrdersByOrderId(int id);
        public void Add(OrderDetail od);

    }
}
