using Assignment_03_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product pro) => ProductDAO.Instance.AddProduct(pro);

        public void DeleteProduct(int id) => ProductDAO.Instance.DeleteProduct(id);

        public Product GetProductById(int id) => ProductDAO.Instance.GetProductById(id);

        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public List<Product> SearchProductByName(string name) => ProductDAO.Instance.SearchProductByName(name);

        public void UpdateProduct(Product pro) => ProductDAO.Instance.UpdateProduct(pro);
    }
}
