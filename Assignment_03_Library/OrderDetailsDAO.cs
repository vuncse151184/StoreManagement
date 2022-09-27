using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.DataAccess
{
    public class OrderDetailsDAO
    {
        private static OrderDetailsDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailsDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailsDAO();
                }
                return instance;
            }
        }
        public IEnumerable<OrderDetail> GetOrdersByOrderId(int id)
        {
            List<OrderDetail> lst = new List<OrderDetail>();
            try
            {
                using var context = new FStoreContext();
                lst = context.OrderDetails.Where(od => od.OrderId == id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lst;
        }
        public void Add(OrderDetail od)
        {
            try
            {
                using var context = new FStoreContext();
                context.OrderDetails.Add(od);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
