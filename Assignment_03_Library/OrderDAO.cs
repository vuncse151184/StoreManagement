using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }
        public int GetNextId()
        {
            using var ctx = new FStoreContext();

            int id = 0;
            if (ctx.Orders.Count() == 0)
            {
                id = 1;
            }
            else
            {
                id = ctx.Orders.Max(order => order.OrderId) + 1;
            }

            return id;

        }
        public Order GetOrderById(int id)
        {
            Order order = new Order();
            try
            {
                using var context = new FStoreContext();
                order = context.Orders.Where(order => order.OrderId == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
        public List<Order> GetOrderByMemberId(int id)
        {
            List<Order> order = new List<Order>();
            try
            {
                using var context = new FStoreContext();
                order = context.Orders.Where(order => order.MemberId == id).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }
        public void AddOrder(Order order)
        {
            try
            {
                using var context = new FStoreContext();
                context.Orders.Add(order);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
