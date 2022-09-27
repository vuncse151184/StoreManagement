using Assignment_03_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_03_Library.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public Product GetProductById(int id);
        public List<Product> SearchProductByName(string name);
        public void AddProduct(Product pro);
        public void UpdateProduct(Product pro);
        public void DeleteProduct(int id);
    }
}
