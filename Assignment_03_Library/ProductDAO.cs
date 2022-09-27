using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductDAO();
                }
                return instance;
            }
        }
        public List<Product> GetProducts()
        {
            using var context = new FStoreContext();
            return context.Products.ToList();
        }
        public Product GetProductById(int id)
        {
            Product pro = new Product();
            try
            {
                using var context = new FStoreContext();
                pro = context.Products.Where(pro => pro.ProductId == id).SingleOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return pro;
        }
        public List<Product> SearchProductByName(string name)
        {
            List<Product> pro = new List<Product>();
            try
            {
                using var context = new FStoreContext();
                pro = context.Products.Where(pro => pro.ProductName.Contains(name)).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return pro;
        }
        public void AddProduct(Product pro)
        {
            try
            {
                var product = GetProductById(pro.ProductId);
                using var context = new FStoreContext();
                if (product != null)
                {
                    throw new Exception("This product id has been used!!!");
                }
                else
                {
                    context.Products.Add(pro);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateProduct(Product pro)
        {
            try
            {
                var product = GetProductById(pro.ProductId);
                using var context = new FStoreContext();
                if (product == null)
                {
                    throw new Exception("This product does not exist!!!");
                }
                else
                {
                    context.Products.Update(pro);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void DeleteProduct(int id)
        {
            try
            {
                var product = GetProductById(id);
                using var context = new FStoreContext();
                if (product == null)
                {
                    throw new Exception("This product does not exist!!!");
                }
                else
                {
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
